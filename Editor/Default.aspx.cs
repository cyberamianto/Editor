﻿using System;
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
                pnInventarioNPC.Visible = false;
                pnNPC.Visible = false;
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                                    mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
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
                mappa.ambienti[r, c] = new Ambiente(btnMetodo.Text, "", 1, "");
                ddlScegliAmbiente.Items.Add(btnMetodo.Text);
            }
            Session["mappa"] = mappa;
        }

        public void AttNPC(string i)
        {
            if (ddlNumElementi.Text == i)
            {
                #region controllo_interfaccia
                lblNome1.Visible = false;
                lblDescrizione1.Visible = false;
                txtNomeEl1Inv.Visible = false;
                txtDescEl1Inv.Visible = false;
                ddlRacIndEl1Inv.Visible = false;
                btnCreaEl1Inv.Visible = false;
                lblNome2.Visible = false;
                lblDescrizione2.Visible = false;
                txtNomeEl2Inv.Visible = false;
                txtDescEl2Inv.Visible = false;
                ddlRacIndEl2Inv.Visible = false;
                btnCreaEl2Inv.Visible = false;
                lblNome3.Visible = false;
                lblDescrizione3.Visible = false;
                txtNomeEl3Inv.Visible = false;
                txtDescEl3Inv.Visible = false;
                ddlRacIndEl3Inv.Visible = false;
                btnCreaEl3Inv.Visible = false;
                lblNome4.Visible = false;
                lblDescrizione4.Visible = false;
                txtNomeEl4Inv.Visible = false;
                txtDescEl4Inv.Visible = false;
                ddlRacIndEl4Inv.Visible = false;
                btnCreaEl4Inv.Visible = false;
                txtNomeEl5Inv.Visible = false;
                lblNome5.Visible = true;
                lblDescrizione5.Visible = false;
                txtNomeEl5Inv.Visible = false;
                txtDescEl5Inv.Visible = false;
                ddlRacIndEl5Inv.Visible = false;
                btnCreaEl5Inv.Visible = false;
                ddlNumElementi.Enabled = true;
                btnNumero.Enabled = true;
                ddlInvAmb.Enabled = true;
                ddlInvAmb.Items.Remove(ddlInvAmb.Text);
                #endregion
            }
            if (ddlNumElementi.Text == i && ddlInvAmb.Text == "")
            {
                pnInventarioAmbiente.Visible = false;
                btnNPCAmbiente.Enabled = true;
            }
        }

        public void AttNPC1(string i)
        {
            if (ddlNumElementiInvNPC.Text == i)
            {
                #region controllo_interfaccia
                lblNome6.Visible = false;
                lblDescrizione6.Visible = false;
                txtNomeEl1InvNPC.Visible = false;
                txtDescEl1InvNPC.Visible = false;
                ddlRacIndEl1InvNPC.Visible = false;
                btnCreaEl1InvNPC.Visible = false;
                btnCreaEl1InvNPC.Enabled = false;
                lblNome7.Visible = false;
                lblDescrizione7.Visible = false;
                txtNomeEl2InvNPC.Visible = false;
                txtDescEl2InvNPC.Visible = false;
                ddlRacIndEl2InvNPC.Visible = false;
                btnCreaEl2InvNPC.Visible = false;
                btnCreaEl2InvNPC.Enabled = false;
                lblNome8.Visible = false;
                lblDescrizione8.Visible = false;
                txtNomeEl3InvNPC.Visible = false;
                txtDescEl3InvNPC.Visible = false;
                ddlRacIndEl3InvNPC.Visible = false;
                btnCreaEl3InvNPC.Visible = false;
                btnCreaEl3InvNPC.Enabled = false;
                lblNome9.Visible = false;
                lblDescrizione9.Visible = false;
                txtNomeEl4InvNPC.Visible = false;
                txtDescEl4InvNPC.Visible = false;
                ddlRacIndEl4InvNPC.Visible = false;
                btnCreaEl4InvNPC.Visible = false;
                btnCreaEl4InvNPC.Enabled = false;
                txtNomeEl5InvNPC.Visible = false;
                lblNome10.Visible = false;
                lblDescrizione10.Visible = false;
                txtNomeEl5InvNPC.Visible = false;
                txtDescEl5InvNPC.Visible = false;
                ddlRacIndEl5InvNPC.Visible = false;
                btnCreaEl5InvNPC.Visible = false;
                btnCreaEl5InvNPC.Enabled = false;
                btnCreaNPC.Enabled = true;
                #endregion
            }
        }

        public void BottElInv(TextBox txtNomeMetodo, TextBox txtDescMetodo, Button btnMetodo, string npc)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            foreach (Ambiente x in mappa.ambienti)
            {
                if (x != null)
                {
                    if (x.Nome == ddlInvAmb.Text)
                    {
                        switch (ddlInvAmb.Text)
                        {
                            case "Strutturale":
                                x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, false, false));
                                break;
                            case "Raccoglibile":
                                x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, true, false));
                                break;
                            case "Raccoglibile-Indossabile":
                                x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, true, true));
                                break;
                        }
                    }
                }
            }
            btnMetodo.Enabled = false;
            AttNPC(npc);
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
            #region gestione_interfaccia
            ddlNumElementi.Enabled = false;
            btnNumero.Enabled = false;
            ddlInvAmb.Enabled = false;
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
                    btnCreaEl1Inv.Enabled = true;
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
                    btnCreaEl1Inv.Enabled = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
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
                    btnCreaEl1Inv.Enabled = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
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
                    btnCreaEl1Inv.Enabled = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    btnCreaEl4Inv.Enabled = true;
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
                    btnCreaEl1Inv.Enabled = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    btnCreaEl4Inv.Enabled = true;
                    txtNomeEl5Inv.Visible = true;
                    lblDescrizione5.Visible = true;
                    txtNomeEl5Inv.Visible = true;
                    txtDescEl5Inv.Visible = true;
                    ddlRacIndEl5Inv.Visible = true;
                    btnCreaEl5Inv.Visible = true;
                    btnCreaEl5Inv.Enabled = true;
                    #endregion
                    break;
            }
            #endregion
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
                foreach(Ambiente x in mappa.ambienti)
                {
                    if(x != null)
                    {
                        ddlInvAmb.Items.Add(x.Nome);
                        ddlAmbNPC.Items.Add(x.Nome);
                    }
                }
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

        protected void btnCreaEl1Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl1Inv, txtDescEl1Inv, btnCreaEl1Inv, "1");
        }

        protected void btnCreaEl2Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl2Inv, txtDescEl2Inv, btnCreaEl2Inv, "2");
        }

        protected void btnCreaEl3Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl3Inv, txtDescEl3Inv, btnCreaEl3Inv, "3");
        }

        protected void btnCreaEl4Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl4Inv, txtDescEl4Inv, btnCreaEl4Inv, "4");
        }

        protected void btnCreaEl5Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl5Inv, txtDescEl5Inv, btnCreaEl5Inv, "5");
        }

        protected void btnNPCAmbiente_Click(object sender, EventArgs e)
        {
            pnNPC.Visible = true;
        }

        protected void btnCreaNPC_Click(object sender, EventArgs e)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            foreach (Ambiente x in mappa.ambienti)
            {
                if (x != null)
                {
                    if (x.Nome == ddlAmbNPC.Text)
                    {
                        x.npcAmb.Add(new NPC(txtNomeNPC.Text, ddlSaluteNPC.Text, int.Parse(ddlLivelloEsp.Text), txtDescNPC.Text, ddlAmbNPC.Text));
                    }
                }
            }
            Session["mappa"] = mappa;
            pnNPC.Enabled = false;
            pnInventarioNPC.Visible = true;
        }

        protected void btnNumeroInvNPC_Click(object sender, EventArgs e)
        {
            #region gestione_interfaccia
            ddlNumElementi.Enabled = false;
            btnNumero.Enabled = false;
            ddlInvAmb.Enabled = false;
            switch (ddlNumElementi.Text)
            {
                case "1":
                    #region gestione_interfaccia
                    lblNome6.Visible = true;
                    lblDescrizione6.Visible = true;
                    txtNomeEl1InvNPC.Visible = true;
                    txtDescEl1InvNPC.Visible = true;
                    ddlRacIndEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Enabled = true;
                    #endregion
                    break;
                case "2":
                    #region controllo_interfaccia
                    lblNome6.Visible = true;
                    lblDescrizione6.Visible = true;
                    txtNomeEl1InvNPC.Visible = true;
                    txtDescEl1InvNPC.Visible = true;
                    ddlRacIndEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Enabled = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    #endregion
                    break;
                case "3":
                    #region controllo_interfaccia
                    lblNome6.Visible = true;
                    lblDescrizione6.Visible = true;
                    txtNomeEl1InvNPC.Visible = true;
                    txtDescEl1InvNPC.Visible = true;
                    ddlRacIndEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Enabled = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    #endregion
                    break;
                case "4":
                    #region controllo_interfaccia
                    lblNome6.Visible = true;
                    lblDescrizione6.Visible = true;
                    txtNomeEl1InvNPC.Visible = true;
                    txtDescEl1InvNPC.Visible = true;
                    ddlRacIndEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Enabled = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    lblNome9.Visible = true;
                    lblDescrizione9.Visible = true;
                    txtNomeEl4InvNPC.Visible = true;
                    txtDescEl4InvNPC.Visible = true;
                    ddlRacIndEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Enabled = true;
                    #endregion
                    break;
                case "5":
                    #region controllo_interfaccia
                    lblNome6.Visible = true;
                    lblDescrizione6.Visible = true;
                    txtNomeEl1InvNPC.Visible = true;
                    txtDescEl1InvNPC.Visible = true;
                    ddlRacIndEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Visible = true;
                    btnCreaEl1InvNPC.Enabled = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    lblNome9.Visible = true;
                    lblDescrizione9.Visible = true;
                    txtNomeEl4InvNPC.Visible = true;
                    txtDescEl4InvNPC.Visible = true;
                    ddlRacIndEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Enabled = true;
                    txtNomeEl5InvNPC.Visible = true;
                    lblNome10.Visible = true;
                    lblDescrizione10.Visible = true;
                    txtNomeEl5InvNPC.Visible = true;
                    txtDescEl5InvNPC.Visible = true;
                    ddlRacIndEl5InvNPC.Visible = true;
                    btnCreaEl5InvNPC.Visible = true;
                    btnCreaEl5InvNPC.Enabled = true;
                    #endregion
                    break;
            }
            #endregion
        }

        protected void btnCreaEl1InvNPC_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl1InvNPC, txtDescEl1InvNPC, btnCreaEl1InvNPC, "1");
        }

        protected void btnCreaEl2InvNPC_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl2InvNPC, txtDescEl2InvNPC, btnCreaEl2InvNPC, "2");
        }

        protected void btnCreaEl3InvNPC_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl3InvNPC, txtDescEl3InvNPC, btnCreaEl3InvNPC, "3");
        }

        protected void btnCreaEl4InvNPC_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl4InvNPC, txtDescEl4InvNPC, btnCreaEl4InvNPC, "4");
        }

        protected void btnCreaEl5InvNPC_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl5InvNPC, txtDescEl5InvNPC, btnCreaEl5InvNPC, "5");
        }
    }
}