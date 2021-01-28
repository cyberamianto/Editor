using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoGame;

namespace Editor
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region getione_interfaccia
            if (!IsPostBack)
            {
                pnAmbienteGenerale.Visible = true;
                pnAmbienteGenerale.Visible = false;
                pnAmbienteSpecifico.Visible = false;
                pnInventarioAmbiente.Visible = false;
                btnAmbiente.Enabled = true;
                btnInventarioAmbiente.Enabled = false;
                btnNPCAmbiente.Enabled = false;
                btnInventarioNPC.Enabled = false;
                Session["mappa"] = new Mappa();
                Session["nAmb"] = 0;
            }
            #endregion
        }
        
        public void bott(Button btnMetodo, int r, int c)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            if ((int)Session["nAmb"] > 0)
            {
                switch(r)
                {
                    case 0:
                        switch(c)
                        {
                            case 0:
                                if(mappa.ambienti[0,1] != null || mappa.ambienti[1,0] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 1:
                                if (mappa.ambienti[0, 0] != null || mappa.ambienti[0, 2] != null || mappa.ambienti[1,1] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 2:
                                if (mappa.ambienti[0, 1] != null || mappa.ambienti[0, 3] != null || mappa.ambienti[1, 2] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 3:
                                if (mappa.ambienti[0, 2] != null || mappa.ambienti[1, 3] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                        }
                        break;
                    case 1:
                        switch (c)
                        {
                            case 0:
                                if (mappa.ambienti[1, 1] != null || mappa.ambienti[0, 0] != null || mappa.ambienti[2, 0] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 1:
                                if (mappa.ambienti[0, 1] != null || mappa.ambienti[1, 0] != null || mappa.ambienti[1, 2] != null || mappa.ambienti[2, 1] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 2:
                                if (mappa.ambienti[0, 2] != null || mappa.ambienti[1, 1] != null || mappa.ambienti[1, 3] != null || mappa.ambienti[2, 2] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 3:
                                if (mappa.ambienti[0, 3] != null || mappa.ambienti[1, 2] != null || mappa.ambienti[2, 3] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch (c)
                        {
                            case 0:
                                if (mappa.ambienti[1, 0] != null || mappa.ambienti[2, 1] != null || mappa.ambienti[3, 0] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 1:
                                if (mappa.ambienti[1, 1] != null || mappa.ambienti[2, 0] != null || mappa.ambienti[2, 2] != null || mappa.ambienti[1, 1] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 2:
                                if (mappa.ambienti[1, 2] != null || mappa.ambienti[2, 1] != null || mappa.ambienti[2, 3] != null || mappa.ambienti[3, 2] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 3:
                                if (mappa.ambienti[1, 3] != null || mappa.ambienti[2, 2] != null || mappa.ambienti[3, 3] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch (c)
                        {
                            case 0:
                                if (mappa.ambienti[2, 0] != null || mappa.ambienti[3, 1] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 1:
                                if (mappa.ambienti[2, 1] != null || mappa.ambienti[3, 0] != null || mappa.ambienti[3, 2] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 2:
                                if (mappa.ambienti[2, 2] != null || mappa.ambienti[3, 1] != null || mappa.ambienti[3, 3] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                            case 3:
                                if (mappa.ambienti[2, 3] != null || mappa.ambienti[3, 2] != null)
                                {
                                    Session["nAmb"] = (int)Session["nAmb"] + 1;
                                    btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                                    btnMetodo.BackColor = System.Drawing.Color.Red;
                                    btnMetodo.Enabled = false;
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                                    ddlScegliAmbiente.Items.Add(btnMetodo.Text);
                                }
                                break;
                        }
                        break;
                }
            }
            else
            {
                Session["nAmb"] = (int)Session["nAmb"] + 1;
                btnMetodo.Text = $"Amb{(int)Session["nAmb"]}";
                btnMetodo.BackColor = System.Drawing.Color.Red;
                btnMetodo.Enabled = false;
                mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1);
                ddlScegliAmbiente.Items.Add(btnMetodo.Text);
            }
            Session["mappa"] = mappa;
        }

        protected void btnAmbiente_Click(object sender, EventArgs e)
        {
            #region getione_interfaccia
            pnAmbienteGenerale.Visible = true;
            btnAmbiente.BackColor = System.Drawing.Color.Red;
            btnAmbiente.Enabled = false;
            #endregion
        }

        protected void btnInventarioAmbiente_Click(object sender, EventArgs e)
        {
            pnAmbienteGenerale.Visible = false;
            pnInventarioAmbiente.Visible = true;
            btnInventarioAmbiente.BackColor = System.Drawing.Color.Red;
            btnInventarioAmbiente.Enabled = false;
        }

        protected void btnNumero_Click(object sender, EventArgs e)
        {
            ddlNumElementi.Enabled = false;
            btnNumero.Enabled = false;
            switch(ddlNumElementi.Text)
            {
                case "1":
                    #region gestione_interfaccia
                    lblNome1.Visible = true;
                    lblDescrizione1.Visible = true;
                    txtNomeEl1Inv.Visible = true;
                    txtDescEl1Inv.Visible = true;
                    ddlRacIndEl1Inv.Visible = true;
                    btnCreaEl1Inv.Visible = true;
                    #endregion
                    break;
                case "2":
                    #region controllo_interfaccia
                    lblNome1.Visible = true;
                    lblDescrizione1.Visible = true;
                    txtNomeEl1Inv.Visible = true;
                    txtDescEl1Inv.Visible = true;
                    ddlRacIndEl1Inv.Visible = true;
                    btnCreaEl1Inv.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    #endregion
                    break;
                case "3":
                    #region controllo_interfaccia
                    lblNome1.Visible = true;
                    lblDescrizione1.Visible = true;
                    txtNomeEl1Inv.Visible = true;
                    txtDescEl1Inv.Visible = true;
                    ddlRacIndEl1Inv.Visible = true;
                    btnCreaEl1Inv.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    #endregion
                    break;
                case "4":
                    #region controllo_interfaccia
                    lblNome1.Visible = true;
                    lblDescrizione1.Visible = true;
                    txtNomeEl1Inv.Visible = true;
                    txtDescEl1Inv.Visible = true;
                    ddlRacIndEl1Inv.Visible = true;
                    btnCreaEl1Inv.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    #endregion
                    break;
                case "5":
                    #region controllo_interfaccia
                    lblNome1.Visible = true;
                    lblDescrizione1.Visible = true;
                    txtNomeEl1Inv.Visible = true;
                    txtDescEl1Inv.Visible = true;
                    ddlRacIndEl1Inv.Visible = true;
                    btnCreaEl1Inv.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    txtNomeEl5Inv.Visible = true;
                    lblDescrizione5.Visible = true;
                    txtNomeEl5Inv.Visible = true;
                    txtDescEl5Inv.Visible = true;
                    ddlRacIndEl5Inv.Visible = true;
                    btnCreaEl5Inv.Visible = true;
                    #endregion
                    break;
            }
        }

        protected void btnCreaEl1Inv_Click(object sender, EventArgs e)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            
        }

        protected void btnCreaMappa_Click(object sender, EventArgs e)
        {
            #region gestione_interfaccia
            btnCreaMappa.Visible = false;
            pnAmbienteGenerale.Enabled = false;
            pnAmbienteSpecifico.Visible = true;
            #endregion
        }

        protected void btnAggiuntaSpecifiche_Click(object sender, EventArgs e)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            foreach(Ambiente x in mappa.ambienti)
            {
                if (x != null)
                {
                    if (x.Nome == ddlScegliAmbiente.Text)
                    {
                        if(txtNomeAmb.Text != "")
                            x.Nome = txtNomeAmb.Text;
                        x.Descrizione = txtDescrizioneAmb.Text;
                        x.Difficoltà = int.Parse(ddlDifficoltà.Text);
                    }
                }
            }
            Session["mappa"] = mappa;
            ddlScegliAmbiente.Items.Remove(ddlScegliAmbiente.Text);
            ddlDifficoltà.SelectedIndex = 0;
            if(ddlScegliAmbiente.Items.Count == 0)
            {
                ddlScegliAmbiente.Items.Add("Ambienti terminati");
                btnAggiuntaSpecifiche.Enabled = false;
                pnAmbienteSpecifico.Visible = false;
                btnInventarioAmbiente.Enabled = true;
            }
        }

        #region rapp_mat
        protected void btn00_Click(object sender, EventArgs e)
        {
            bott(btn00, 0, 0);
        }

        protected void btn01_Click(object sender, EventArgs e)
        {
            bott(btn01, 0, 1);
        }

        protected void btn02_Click(object sender, EventArgs e)
        {
            bott(btn02, 0, 2);
        }

        protected void btn03_Click(object sender, EventArgs e)
        {
            bott(btn03, 0, 3);
        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            bott(btn10, 1, 0);
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            bott(btn11, 1, 1);
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            bott(btn12, 1, 2);
        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            bott(btn13, 1, 3);
        }

        protected void btn20_Click(object sender, EventArgs e)
        {
            bott(btn20, 2, 0);
        }

        protected void btn21_Click(object sender, EventArgs e)
        {
            bott(btn21, 2, 1);
        }

        protected void btn22_Click(object sender, EventArgs e)
        {
            bott(btn22, 2, 2);
        }

        protected void btn23_Click(object sender, EventArgs e)
        {
            bott(btn23, 2, 3);
        }

        protected void btn30_Click(object sender, EventArgs e)
        {
            bott(btn30, 3, 0);
        }

        protected void btn31_Click(object sender, EventArgs e)
        {
            bott(btn31, 3, 1);
        }

        protected void btn32_Click(object sender, EventArgs e)
        {
            bott(btn32, 3, 2);
        }

        protected void btn33_Click(object sender, EventArgs e)
        {
            bott(btn33, 3, 3);
        }
        #endregion
    }
}