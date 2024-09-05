using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Kiccc.Ing.PcPos;
using Kiccc.Ing.PcPos.Serial;

namespace KicccIngenicoTestClient
{
    public partial class FrmMain : Form
    {
        private SerialIngenico _driver;


        public FrmMain()
        {
            InitializeComponent();


            var multiplex = new Kiccc.Ing.PcPos.MultiplexPayment();

            


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            var g = Guid.NewGuid().ToString();




            Closing += (s, ev) =>
            {
                Registery.Register(new Setting()
                {
                    SerialNo = txtSerial.Text,
                    TerminalId = txtTerminal.Text,
                    AcceptorId = txtAcceptor.Text,
                    Organization = txtOrgCode.Text,
                    ServiceCode = txtSrvCode.Text,
                    BankCode = txtBankCode.Text,
                    Financialyear = txtYearCode.Text,
                    FiscalPeriod = txtPeriodCode.Text,
                    SequenceCode = txtSeqCode.Text
                });
                _driver.Dispose();
            };


            var lastSet = Registery.Load();

            if (lastSet != null)
            {
                txtSerial.Text = lastSet.SerialNo;
                txtTerminal.Text = lastSet.TerminalId;
                txtAcceptor.Text = lastSet.AcceptorId;
                txtOrgCode.Text = lastSet.Organization;
                txtSeqCode.Text = lastSet.SequenceCode;
                txtSrvCode.Text = lastSet.ServiceCode;
                txtBankCode.Text = lastSet.BankCode;
                txtYearCode.Text = lastSet.Financialyear;
                txtPeriodCode.Text = lastSet.FiscalPeriod;
            }

            cmbCom.DataSource = SerialPort.GetPortNames();


            _driver = new SerialIngenico();

            _driver.ResponseReceived += (s, ev) =>
            {
                MessageBox.Show(ev.Response);
                gBoxSettings.Enabled = true;
                gBoxSyncMethods.Enabled = true;
                gBoxAsyncMethods.Enabled = true;
                progressBar1.Style = ProgressBarStyle.Blocks;
            };

            btnInitiate.Click += (s, ev) =>
            {
                try
                {
                    // Initiate Service
                    _driver.InitiateService(txtSerial.Text, txtAcceptor.Text, txtTerminal.Text, cmbCom.Text, 115200, 8,
                        SerialPortStopBit.One,
                        SerialPortParity.None);
                    //
                    //
                    btnInitiate.Enabled = false;
                    btnTerminate.Enabled = true;
                    btnReset.Enabled = true;
                    gBoxAsyncMethods.Enabled = true;
                    gBoxSyncMethods.Enabled = true;
                    gBoxMultiplex.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnReset.Click += (s, ev) =>
            {
                try
                {
                    // Reset Service
                    _driver.ResetService();
                    //
                    //
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnTerminate.Click += (s, ev) =>
            {
                try
                {
                    // Terminate Service
                    _driver.TerminateService();
                    btnInitiate.Enabled = true;
                    btnTerminate.Enabled = false;
                    btnReset.Enabled = false;
                    gBoxAsyncMethods.Enabled = false;
                    gBoxSyncMethods.Enabled = false;
                    gBoxMultiplex.Enabled = false;
                    //
                    //
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };


            btnAddAmount.Click += (s, ev) =>
            {
                if (lstAmounts.Items.Count == 10 || string.IsNullOrEmpty(txtMultiAmount.Text) ||
                    !Regex.IsMatch(txtMultiAmount.Text, "^[1-9]{1}[0-9]{0,8}$")) return;
                var itm = new ListViewItem(){Text = string.Format("مبلغ {0}", lstAmounts.Items.Count + 1)};
                itm.SubItems.Add(txtMultiAmount.Text);

                lstAmounts.Items.Add(itm);
            };

            btnRemoveAmount.Click += (s, ev) =>
            { if (lstAmounts.Items.Count > 0) lstAmounts.Items.RemoveAt(lstAmounts.Items.Count - 1); };

            btnSale.Click += (s, ev) =>
            {
                try
                {
                    var res = _driver.Sale(txtAmount.Text);
                    MessageBox.Show(res);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnSaleWithPaymentId.Click += (s, ev) =>
            {
                try
                {
                    MessageBox.Show(_driver.SaleWithPaymentId(txtAmount.Text, txtPaymrntId.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnMultiplexSale.Click += (s, ev) =>
            {
                try
                {
                    var p = new MultiplexPayment()
                    {
                        BankCode = txtBankCode.Text,
                        Organization = txtOrgCode.Text,
                        ServiceCode = txtSrvCode.Text,
                        Financialyear = txtYearCode.Text,
                        FiscalPeriod = txtPeriodCode.Text,
                        SequenceCode = txtSeqCode.Text,
                        PaymentId = txtMultiPaymentId.Text
                    };

                    foreach (ListViewItem itm in lstAmounts.Items)
                    {
                        p.Amounts.Add(itm.SubItems[1].Text);
                    }

                    MessageBox.Show(_driver.MultiplexPayment(p));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnAsyncMultiplexSale.Click += (s, ev) =>
            {

                try
                {
                    var p = new MultiplexPayment()
                    {
                        BankCode = txtBankCode.Text,
                        Organization = txtOrgCode.Text,
                        ServiceCode = txtSrvCode.Text,
                        Financialyear = txtYearCode.Text,
                        FiscalPeriod = txtPeriodCode.Text,
                        SequenceCode = txtSeqCode.Text,
                        PaymentId = txtMultiPaymentId.Text
                    };

                    foreach (ListViewItem itm in lstAmounts.Items)
                    {
                        p.Amounts.Add(itm.SubItems[1].Text);
                    }



                    gBoxSettings.Enabled = false;
                    gBoxSyncMethods.Enabled = false;
                    gBoxAsyncMethods.Enabled = false;
                    progressBar1.Style = ProgressBarStyle.Marquee;

                    _driver.BeginMultiplexPayment(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
                try
                {
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };


            btnAsyncSale.Click += (s, ev) =>
            {
                try
                {
                    gBoxSettings.Enabled = false;
                    gBoxSyncMethods.Enabled = false;
                    gBoxAsyncMethods.Enabled = false;
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    _driver.BeginSale(txtAmount.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };

            btnAsyncSaleWithPaymentId.Click += (s, ev) =>
            {
                try
                {
                    gBoxSettings.Enabled = false;
                    gBoxSyncMethods.Enabled = false;
                    gBoxAsyncMethods.Enabled = false;
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    _driver.BeginSaleWithPaymentId(txtAmount.Text, txtPaymrntId.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Exception : {0}\r\nInner Exception : {1}", ex.Message,
                        ex.InnerException != null ? ex.InnerException.Message : string.Empty));
                }
            };
        }




    }
}
