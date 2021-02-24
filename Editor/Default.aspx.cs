using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using VideoGame;
using System.Runtime.Serialization;
using System.Xml;

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
                pnPlayer.Visible = false;
                btnAmbiente.Enabled = true;
                btnInventarioAmbiente.Enabled = false;
                btnNPCAmbiente.Enabled = false;
                btnPlayer.Enabled = false;
                Session["mappa"] = new Mappa(new Player("", "", 0, ""));
                Session["player"] = null;
                Session["nAmb"] = 0;
                Session["counterBtn"] = 1;
            }
            #endregion
        }

        public void BottMat(Button btnMetodo, int r, int c)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            if ((int)Session["nAmb"] > 0)
            {
                switch (r)
                {
                    case 0:
                        switch (c)
                        {
                            case 0:
                                if (mappa.ambienti[0, 1] != null || mappa.ambienti[1, 0] != null)
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
                                if (mappa.ambienti[0, 0] != null || mappa.ambienti[0, 2] != null || mappa.ambienti[1, 1] != null)
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

        public void AttNPC(int i)
        {
            if (int.Parse(ddlNumElementi.Text) == i)
            {
                #region controllo_interfaccia
                lblNome1.Visible = false;
                lblDescrizione1.Visible = false;
                txtNomeEl1Inv.Visible = false;
                txtDescEl1Inv.Visible = false;
                ddlRacIndEl1Inv.Visible = false;
                btnCreaEl1Inv.Visible = false;
                btnCreaEl1Inv.Enabled = false;
                btnCaricaImgEl1Inv.Enabled = false;
                btnCaricaImgEl1Inv.Visible = false;
                fuEl1Inv.Enabled = false;
                fuEl1Inv.Visible = false;
                imgEl1Inv.Visible = false;
                lblNome2.Visible = false;
                lblDescrizione2.Visible = false;
                txtNomeEl2Inv.Visible = false;
                txtDescEl2Inv.Visible = false;
                ddlRacIndEl2Inv.Visible = false;
                btnCreaEl2Inv.Visible = false;
                btnCreaEl2Inv.Enabled = false;
                btnCaricaImgEl2Inv.Enabled = false;
                btnCaricaImgEl2Inv.Visible = false;
                fuEl2Inv.Enabled = false;
                fuEl2Inv.Visible = false;
                imgEl2Inv.Visible = false;
                lblNome3.Visible = false;
                lblDescrizione3.Visible = false;
                txtNomeEl3Inv.Visible = false;
                txtDescEl3Inv.Visible = false;
                ddlRacIndEl3Inv.Visible = false;
                btnCreaEl3Inv.Visible = false;
                btnCreaEl3Inv.Enabled = false;
                btnCaricaImgEl3Inv.Enabled = false;
                btnCaricaImgEl3Inv.Visible = false;
                fuEl3Inv.Enabled = false;
                fuEl3Inv.Visible = false;
                imgEl3Inv.Visible = false;
                lblNome4.Visible = false;
                lblDescrizione4.Visible = false;
                txtNomeEl4Inv.Visible = false;
                txtDescEl4Inv.Visible = false;
                ddlRacIndEl4Inv.Visible = false;
                btnCreaEl4Inv.Visible = false;
                btnCreaEl4Inv.Enabled = false;
                txtNomeEl5Inv.Visible = false;
                btnCaricaImgEl4Inv.Enabled = false;
                btnCaricaImgEl4Inv.Visible = false;
                fuEl4Inv.Enabled = false;
                fuEl4Inv.Visible = false;
                imgEl4Inv.Visible = false;
                lblNome5.Visible = false;
                lblDescrizione5.Visible = false;
                txtNomeEl5Inv.Visible = false;
                txtDescEl5Inv.Visible = false;
                ddlRacIndEl5Inv.Visible = false;
                btnCreaEl5Inv.Visible = false;
                btnCreaEl5Inv.Enabled = false;
                btnCaricaImgEl5Inv.Enabled = false;
                btnCaricaImgEl5Inv.Visible = false;
                fuEl5Inv.Enabled = false;
                fuEl5Inv.Visible = false;
                imgEl5Inv.Visible = false;
                ddlNumElementi.Enabled = true;
                btnNumero.Enabled = true;
                ddlInvAmb.Enabled = true;
                ddlInvAmb.Items.Remove(ddlInvAmb.Text);
                #endregion
                Session["counterBtn"] = 1;
            }
            else
            {
                Session["counterBtn"] = (int)Session["counterBtn"] + 1;
                return;
            }
            if (int.Parse(ddlNumElementi.Text) == i && ddlInvAmb.Text == "")
            {
                pnInventarioAmbiente.Visible = false;
                btnNPCAmbiente.Enabled = true;
                //btnPlayer.Enabled = true;
                Session["counterBtn"] = 1;
            }
        }

        public void AttNPC1(int i)
        {
            if (int.Parse(ddlNumElementiInvNPC.Text) == i)
            {
                #region controllo_interfaccia
                lblNome6.Visible = false;
                lblDescrizione6.Visible = false;
                txtNomeEl1InvNPC.Visible = false;
                txtDescEl1InvNPC.Visible = false;
                ddlRacIndEl1InvNPC.Visible = false;
                btnCreaEl1InvNPC.Visible = false;
                btnCreaEl1InvNPC.Enabled = false;
                btnCaricaImgEl1InvNPC.Enabled = false;
                btnCaricaImgEl1InvNPC.Visible = false;
                fuEl1InvNPC.Enabled = false;
                fuEl1InvNPC.Visible = false;
                imgEl1InvNPC.Visible = false;
                lblNome7.Visible = false;
                lblDescrizione7.Visible = false;
                txtNomeEl2InvNPC.Visible = false;
                txtDescEl2InvNPC.Visible = false;
                ddlRacIndEl2InvNPC.Visible = false;
                btnCreaEl2InvNPC.Visible = false;
                btnCreaEl2InvNPC.Enabled = false;
                btnCaricaImgEl2InvNPC.Enabled = false;
                btnCaricaImgEl2InvNPC.Visible = false;
                fuEl2InvNPC.Enabled = false;
                fuEl2InvNPC.Visible = false;
                imgEl2InvNPC.Visible = false;
                lblNome8.Visible = false;
                lblDescrizione8.Visible = false;
                txtNomeEl3InvNPC.Visible = false;
                txtDescEl3InvNPC.Visible = false;
                ddlRacIndEl3InvNPC.Visible = false;
                btnCreaEl3InvNPC.Visible = false;
                btnCreaEl3InvNPC.Enabled = false;
                btnCaricaImgEl3InvNPC.Enabled = false;
                btnCaricaImgEl3InvNPC.Visible = false;
                fuEl3InvNPC.Enabled = false;
                fuEl3InvNPC.Visible = false;
                imgEl3InvNPC.Visible = false;
                lblNome9.Visible = false;
                lblDescrizione9.Visible = false;
                txtNomeEl4InvNPC.Visible = false;
                txtDescEl4InvNPC.Visible = false;
                ddlRacIndEl4InvNPC.Visible = false;
                btnCreaEl4InvNPC.Visible = false;
                btnCreaEl4InvNPC.Enabled = false;
                txtNomeEl5InvNPC.Visible = false;
                btnCaricaImgEl4InvNPC.Enabled = false;
                btnCaricaImgEl4InvNPC.Visible = false;
                fuEl4InvNPC.Enabled = false;
                fuEl4InvNPC.Visible = false;
                imgEl4InvNPC.Visible = false;
                lblNome10.Visible = false;
                lblDescrizione10.Visible = false;
                txtNomeEl5InvNPC.Visible = false;
                txtDescEl5InvNPC.Visible = false;
                ddlRacIndEl5InvNPC.Visible = false;
                btnCreaEl5InvNPC.Visible = false;
                btnCreaEl5InvNPC.Enabled = false;
                btnCaricaImgEl5InvNPC.Enabled = false;
                btnCaricaImgEl5InvNPC.Visible = false;
                fuEl5InvNPC.Enabled = false;
                fuEl5InvNPC.Visible = false;
                imgEl5InvNPC.Visible = false;
                btnCreaNPC.Enabled = true;
                pnInventarioNPC.Visible = false;
                pnNPC.Enabled = true;
                btnPlayer.Enabled = true;
                #endregion
                Session["counterBtn"] = 1;
            }
            else
            {
                Session["counterBtn"] = (int)Session["counterBtn"] + 1;
                return;
            }
        }

        public void BottElInv(TextBox txtNomeMetodo, TextBox txtDescMetodo, Button btnMetodo, DropDownList ddlMetodo, string byteImgMetodo, int npc)
        {
            if ((int)Session["counterBtn"] == npc)
            {
                Mappa mappa = (Mappa)Session["mappa"];
                foreach (Ambiente x in mappa.ambienti)
                {
                    if (x != null)
                    {
                        if (x.Nome == ddlInvAmb.Text)
                        {
                            switch (ddlMetodo.Text)
                            {
                                case "Strutturale":
                                    x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, false, false, (byte[])Session[byteImgMetodo]));
                                    break;
                                case "Raccoglibile":
                                    x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, true, false, (byte[])Session[byteImgMetodo]));
                                    break;
                                case "Raccoglibile-Indossabile":
                                    x.InvAmbiente.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, true, true, (byte[])Session[byteImgMetodo]));
                                    break;
                            }
                        }
                    }
                }
                btnMetodo.Enabled = false;
                AttNPC(npc);
                Session["mappa"] = mappa;
            }
        }

        public void BottElInvNPC(TextBox txtNomeMetodo, TextBox txtDescMetodo, Button btnMetodo, DropDownList ddlMetodo, string byteImgMetodo, int npc)
        {
            if ((int)Session["counterBtn"] == npc)
            {
                Mappa mappa = (Mappa)Session["mappa"];
                foreach (Ambiente x in mappa.ambienti)
                {
                    if (x != null)
                    {
                        if (x.Nome == ddlAmbNPC.Text)
                        {
                            foreach (NPC y in x.npcAmb)
                            {
                                if (y.Nome == txtNomeNPC.Text)
                                {
                                    switch (ddlMetodo.Text)
                                    {
                                        case "Indossabile":
                                            y.Inv.Add(new Entity(txtNomeMetodo.Text, txtDescMetodo.Text, false, true, (byte[])Session[byteImgMetodo]));
                                            break;
                                        case "Arma":
                                            y.Inv.Add(new Arma(txtNomeMetodo.Text, txtDescMetodo.Text, 7, 5, (byte[])Session[byteImgMetodo]));
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
                btnMetodo.Enabled = false;

                AttNPC1(npc);
                Session["mappa"] = mappa;
            }
        }

        public void CaricaImgInv(string byteImg, FileUpload fuMetodo, Image imgMetodo)
        {
            if (fuMetodo.HasFile)
            {
                Session[byteImg] = fuMetodo.FileBytes;
                imgMetodo.ImageUrl = "data:image;base64," + Convert.ToBase64String((byte[])Session[byteImg]);
            }
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
            switch (ddlNumElementi.Text)
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
                    btnCaricaImgEl1Inv.Enabled = true;
                    btnCaricaImgEl1Inv.Visible = true;
                    fuEl1Inv.Enabled = true;
                    fuEl1Inv.Visible = true;
                    imgEl1Inv.Visible = true;
                    lblSelezionaSkin1.Visible = true;
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
                    btnCaricaImgEl1Inv.Enabled = true;
                    btnCaricaImgEl1Inv.Visible = true;
                    fuEl1Inv.Enabled = true;
                    fuEl1Inv.Visible = true;
                    imgEl1Inv.Visible = true;
                    lblSelezionaSkin1.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Visible = true;
                    fuEl2Inv.Enabled = true;
                    fuEl2Inv.Visible = true;
                    imgEl2Inv.Visible = true;
                    lblSelezionaSkin2.Visible = true;
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
                    btnCaricaImgEl1Inv.Enabled = true;
                    btnCaricaImgEl1Inv.Visible = true;
                    fuEl1Inv.Enabled = true;
                    fuEl1Inv.Visible = true;
                    imgEl1Inv.Visible = true;
                    lblSelezionaSkin1.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Visible = true;
                    fuEl2Inv.Enabled = true;
                    fuEl2Inv.Visible = true;
                    imgEl2Inv.Visible = true;
                    lblSelezionaSkin2.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Visible = true;
                    fuEl3Inv.Enabled = true;
                    fuEl3Inv.Visible = true;
                    imgEl3Inv.Visible = true;
                    lblSelezionaSkin3.Visible = true;

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
                    btnCaricaImgEl1Inv.Enabled = true;
                    btnCaricaImgEl1Inv.Visible = true;
                    fuEl1Inv.Enabled = true;
                    fuEl1Inv.Visible = true;
                    imgEl1Inv.Visible = true;
                    lblSelezionaSkin1.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Visible = true;
                    fuEl2Inv.Enabled = true;
                    fuEl2Inv.Visible = true;
                    imgEl2Inv.Visible = true;
                    lblSelezionaSkin2.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Visible = true;
                    fuEl3Inv.Enabled = true;
                    fuEl3Inv.Visible = true;
                    imgEl3Inv.Visible = true;
                    lblSelezionaSkin3.Visible = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    btnCreaEl4Inv.Enabled = true;
                    btnCaricaImgEl4Inv.Enabled = true;
                    btnCaricaImgEl4Inv.Visible = true;
                    fuEl4Inv.Enabled = true;
                    fuEl4Inv.Visible = true;
                    imgEl4Inv.Visible = true;
                    lblSelezionaSkin4.Visible = true;
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
                    btnCaricaImgEl1Inv.Enabled = true;
                    btnCaricaImgEl1Inv.Visible = true;
                    fuEl1Inv.Enabled = true;
                    fuEl1Inv.Visible = true;
                    imgEl1Inv.Visible = true;
                    lblSelezionaSkin1.Visible = true;
                    lblNome2.Visible = true;
                    lblDescrizione2.Visible = true;
                    txtNomeEl2Inv.Visible = true;
                    txtDescEl2Inv.Visible = true;
                    ddlRacIndEl2Inv.Visible = true;
                    btnCreaEl2Inv.Visible = true;
                    btnCreaEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Enabled = true;
                    btnCaricaImgEl2Inv.Visible = true;
                    fuEl2Inv.Enabled = true;
                    fuEl2Inv.Visible = true;
                    imgEl2Inv.Visible = true;
                    lblSelezionaSkin2.Visible = true;
                    lblNome3.Visible = true;
                    lblDescrizione3.Visible = true;
                    txtNomeEl3Inv.Visible = true;
                    txtDescEl3Inv.Visible = true;
                    ddlRacIndEl3Inv.Visible = true;
                    btnCreaEl3Inv.Visible = true;
                    btnCreaEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Enabled = true;
                    btnCaricaImgEl3Inv.Visible = true;
                    fuEl3Inv.Enabled = true;
                    fuEl3Inv.Visible = true;
                    imgEl3Inv.Visible = true;
                    lblSelezionaSkin3.Visible = true;
                    lblNome4.Visible = true;
                    lblDescrizione4.Visible = true;
                    txtNomeEl4Inv.Visible = true;
                    txtDescEl4Inv.Visible = true;
                    ddlRacIndEl4Inv.Visible = true;
                    btnCreaEl4Inv.Visible = true;
                    btnCreaEl4Inv.Enabled = true;
                    txtNomeEl5Inv.Visible = true;
                    btnCaricaImgEl4Inv.Enabled = true;
                    btnCaricaImgEl4Inv.Visible = true;
                    fuEl4Inv.Enabled = true;
                    fuEl4Inv.Visible = true;
                    imgEl4Inv.Visible = true;
                    lblSelezionaSkin4.Visible = true;
                    lblNome5.Visible = true;
                    lblDescrizione5.Visible = true;
                    txtNomeEl5Inv.Visible = true;
                    txtDescEl5Inv.Visible = true;
                    ddlRacIndEl5Inv.Visible = true;
                    btnCreaEl5Inv.Visible = true;
                    btnCreaEl5Inv.Enabled = true;
                    btnCaricaImgEl5Inv.Enabled = true;
                    btnCaricaImgEl5Inv.Visible = true;
                    fuEl5Inv.Enabled = true;
                    fuEl5Inv.Visible = true;
                    imgEl5Inv.Visible = true;
                    lblSelezionaSkin5.Visible = true;
                    #endregion
                    break;
            }
            #endregion
        }

        protected void btnCreaMappa_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach(Ambiente x in ((Mappa)Session["mappa"]).ambienti)
            {
                if (x != null)
                    ok = true;
            }
            if (ok)
            {
                #region gestione_interfaccia
                btnCreaMappa.Visible = false;
                pnAmbienteGenerale.Enabled = false;
                pnAmbienteSpecifico.Visible = true;
                btnAggiuntaSpecifiche.Enabled = false;
                #endregion
            }
        }

        protected void btnAggiuntaSpecifiche_Click(object sender, EventArgs e)
        {
            lblErrAmb.Text = "";
            if (txtNomeAmb.Text != "")
            {
                Mappa mappa = (Mappa)Session["mappa"];
                foreach (Ambiente x in mappa.ambienti)
                {
                    if (x != null)
                    {
                        if (x.Nome == ddlScegliAmbiente.Text)
                        {
                            bool ok = true;
                            foreach (Ambiente y in mappa.ambienti)
                            {
                                if (y != null)
                                {
                                    if (y.Nome == txtNomeAmb.Text)
                                    {
                                        ok = false;
                                        break;
                                    }
                                }
                            }
                            if (txtNomeAmb.Text != "" && ok)
                            {
                                x.Nome = txtNomeAmb.Text;
                                x.Descrizione = txtDescrizioneAmb.Text;
                                x.Difficoltà = int.Parse(ddlDifficoltà.Text);
                                x.Background = (byte[])Session["byteImgAmb"];
                                lblErrAmb.Text = "";
                            }
                            else
                            {
                                lblErrAmb.Text = "Errore! Inserire nomi diversi per i diversi ambienti!";
                                return;
                            }
                        }
                    }
                }
                Session["mappa"] = mappa;
                ddlScegliAmbiente.Items.Remove(ddlScegliAmbiente.Text);
                ddlDifficoltà.SelectedIndex = 0;
                txtNomeAmb.Text = "";
                txtDescrizioneAmb.Text = "";
                imgAmb.Visible = false;
                btnAggiuntaSpecifiche.Enabled = false;
                fuAmb.Enabled = true;
                if (ddlScegliAmbiente.Items.Count == 0)
                {
                    foreach (Ambiente x in mappa.ambienti)
                    {
                        if (x != null)
                        {
                            ddlInvAmb.Items.Add(x.Nome);
                            ddlAmbNPC.Items.Add(x.Nome);
                            ddlAmbInitPlayer.Items.Add(x.Nome);
                        }
                    }
                    ddlScegliAmbiente.Items.Add("Ambienti terminati");
                    btnAggiuntaSpecifiche.Enabled = false;
                    pnAmbienteSpecifico.Visible = false;
                    btnInventarioAmbiente.Enabled = true;
                }
            }
            else
                lblErrAmb.Text = "Inserire un nome per l'ambiente";
        }

        #region rapp_mat
        protected void btn00_Click(object sender, EventArgs e)
        {
            BottMat(btn00, 0, 0);
        }

        protected void btn01_Click(object sender, EventArgs e)
        {
            BottMat(btn01, 0, 1);
        }

        protected void btn02_Click(object sender, EventArgs e)
        {
            BottMat(btn02, 0, 2);
        }

        protected void btn03_Click(object sender, EventArgs e)
        {
            BottMat(btn03, 0, 3);
        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            BottMat(btn10, 1, 0);
        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            BottMat(btn11, 1, 1);
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            BottMat(btn12, 1, 2);
        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            BottMat(btn13, 1, 3);
        }

        protected void btn20_Click(object sender, EventArgs e)
        {
            BottMat(btn20, 2, 0);
        }

        protected void btn21_Click(object sender, EventArgs e)
        {
            BottMat(btn21, 2, 1);
        }

        protected void btn22_Click(object sender, EventArgs e)
        {
            BottMat(btn22, 2, 2);
        }

        protected void btn23_Click(object sender, EventArgs e)
        {
            BottMat(btn23, 2, 3);
        }

        protected void btn30_Click(object sender, EventArgs e)
        {
            BottMat(btn30, 3, 0);
        }

        protected void btn31_Click(object sender, EventArgs e)
        {
            BottMat(btn31, 3, 1);
        }

        protected void btn32_Click(object sender, EventArgs e)
        {
            BottMat(btn32, 3, 2);
        }

        protected void btn33_Click(object sender, EventArgs e)
        {
            BottMat(btn33, 3, 3);
        }
        #endregion

        protected void btnCreaEl1Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl1Inv, txtDescEl1Inv, btnCreaEl1Inv, ddlRacIndEl1Inv, "byteImgEl1", 1);
        }

        protected void btnCreaEl2Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl2Inv, txtDescEl2Inv, btnCreaEl2Inv, ddlRacIndEl2Inv, "byteImgEl2", 2);
        }

        protected void btnCreaEl3Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl3Inv, txtDescEl3Inv, btnCreaEl3Inv, ddlRacIndEl3Inv, "byteImgEl3", 3);
        }

        protected void btnCreaEl4Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl4Inv, txtDescEl4Inv, btnCreaEl4Inv, ddlRacIndEl4Inv, "byteImgEl4", 4);
        }

        protected void btnCreaEl5Inv_Click(object sender, EventArgs e)
        {
            BottElInv(txtNomeEl5Inv, txtDescEl5Inv, btnCreaEl5Inv, ddlRacIndEl5Inv, "byteImgEl5", 5);
        }

        protected void btnNPCAmbiente_Click(object sender, EventArgs e)
        {
            btnNPCAmbiente.Enabled = false;
            btnNPCAmbiente.BackColor = System.Drawing.Color.Red;
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
                        bool ok = true;
                        foreach(NPC y in x.npcAmb)
                        {
                            if (y.Nome == txtNomeNPC.Text)
                                ok = false;
                        }
                        if(ok)
                            x.npcAmb.Add(new NPC(txtNomeNPC.Text, ddlSaluteNPC.Text, int.Parse(ddlLivelloEsp.Text), txtDescNPC.Text, ddlAmbNPC.Text, txtFraseNPC.Text));
                        else
                        {
                            lblErrNPC.Text = "Errore! Inserire nomi diversi per i diversi ambienti!";
                            return;
                        }
                    }
                }
            }
            Session["mappa"] = mappa;
            pnNPC.Enabled = false;
            pnInventarioNPC.Visible = true;
            btnPlayer.Enabled = false;
        }

        protected void btnNumeroInvNPC_Click(object sender, EventArgs e)
        {
            #region gestione_interfaccia
            ddlNumElementi.Enabled = false;
            btnNumero.Enabled = false;
            ddlInvAmb.Enabled = false;
            switch (ddlNumElementiInvNPC.Text)
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
                    btnCaricaImgEl1InvNPC.Enabled = true;
                    btnCaricaImgEl1InvNPC.Visible = true;
                    fuEl1InvNPC.Enabled = true;
                    fuEl1InvNPC.Visible = true;
                    imgEl1InvNPC.Visible = true;
                    lblSelezionaSkinNPC1.Visible = true;
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
                    btnCaricaImgEl1InvNPC.Enabled = true;
                    btnCaricaImgEl1InvNPC.Visible = true;
                    fuEl1InvNPC.Enabled = true;
                    fuEl1InvNPC.Visible = true;
                    imgEl1InvNPC.Visible = true;
                    lblSelezionaSkinNPC1.Visible = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Visible = true;
                    fuEl2InvNPC.Enabled = true;
                    fuEl2InvNPC.Visible = true;
                    imgEl2InvNPC.Visible = true;
                    lblSelezionaSkinNPC2.Visible = true;
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
                    btnCaricaImgEl1InvNPC.Enabled = true;
                    btnCaricaImgEl1InvNPC.Visible = true;
                    fuEl1InvNPC.Enabled = true;
                    fuEl1InvNPC.Visible = true;
                    imgEl1InvNPC.Visible = true;
                    lblSelezionaSkinNPC1.Visible = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Visible = true;
                    fuEl2InvNPC.Enabled = true;
                    fuEl2InvNPC.Visible = true;
                    imgEl2InvNPC.Visible = true;
                    lblSelezionaSkinNPC2.Visible = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Visible = true;
                    fuEl3InvNPC.Enabled = true;
                    fuEl3InvNPC.Visible = true;
                    imgEl3InvNPC.Visible = true;
                    lblSelezionaSkinNPC3.Visible = true;
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
                    btnCaricaImgEl1InvNPC.Enabled = true;
                    btnCaricaImgEl1InvNPC.Visible = true;
                    fuEl1InvNPC.Enabled = true;
                    fuEl1InvNPC.Visible = true;
                    imgEl1InvNPC.Visible = true;
                    lblSelezionaSkinNPC1.Visible = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Visible = true;
                    fuEl2InvNPC.Enabled = true;
                    fuEl2InvNPC.Visible = true;
                    imgEl2InvNPC.Visible = true;
                    lblSelezionaSkinNPC2.Visible = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Visible = true;
                    fuEl3InvNPC.Enabled = true;
                    fuEl3InvNPC.Visible = true;
                    imgEl3InvNPC.Visible = true;
                    lblSelezionaSkinNPC3.Visible = true;
                    lblNome9.Visible = true;
                    lblDescrizione9.Visible = true;
                    txtNomeEl4InvNPC.Visible = true;
                    txtDescEl4InvNPC.Visible = true;
                    ddlRacIndEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Enabled = true;
                    btnCaricaImgEl4InvNPC.Enabled = true;
                    btnCaricaImgEl4InvNPC.Visible = true;
                    fuEl4InvNPC.Enabled = true;
                    fuEl4InvNPC.Visible = true;
                    imgEl4InvNPC.Visible = true;
                    lblSelezionaSkinNPC4.Visible = true;
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
                    btnCaricaImgEl1InvNPC.Enabled = true;
                    btnCaricaImgEl1InvNPC.Visible = true;
                    fuEl1InvNPC.Enabled = true;
                    fuEl1InvNPC.Visible = true;
                    imgEl1InvNPC.Visible = true;
                    lblSelezionaSkinNPC1.Visible = true;
                    lblNome7.Visible = true;
                    lblDescrizione7.Visible = true;
                    txtNomeEl2InvNPC.Visible = true;
                    txtDescEl2InvNPC.Visible = true;
                    ddlRacIndEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Visible = true;
                    btnCreaEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Enabled = true;
                    btnCaricaImgEl2InvNPC.Visible = true;
                    fuEl2InvNPC.Enabled = true;
                    fuEl2InvNPC.Visible = true;
                    imgEl2InvNPC.Visible = true;
                    lblSelezionaSkinNPC2.Visible = true;
                    lblNome8.Visible = true;
                    lblDescrizione8.Visible = true;
                    txtNomeEl3InvNPC.Visible = true;
                    txtDescEl3InvNPC.Visible = true;
                    ddlRacIndEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Visible = true;
                    btnCreaEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Enabled = true;
                    btnCaricaImgEl3InvNPC.Visible = true;
                    fuEl3InvNPC.Enabled = true;
                    fuEl3InvNPC.Visible = true;
                    imgEl3InvNPC.Visible = true;
                    lblSelezionaSkinNPC3.Visible = true;
                    lblNome9.Visible = true;
                    lblDescrizione9.Visible = true;
                    txtNomeEl4InvNPC.Visible = true;
                    txtDescEl4InvNPC.Visible = true;
                    ddlRacIndEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Visible = true;
                    btnCreaEl4InvNPC.Enabled = true;
                    txtNomeEl5InvNPC.Visible = true;
                    btnCaricaImgEl4InvNPC.Enabled = true;
                    btnCaricaImgEl4InvNPC.Visible = true;
                    fuEl4InvNPC.Enabled = true;
                    fuEl4InvNPC.Visible = true;
                    imgEl4InvNPC.Visible = true;
                    lblSelezionaSkinNPC4.Visible = true;
                    lblNome10.Visible = true;
                    lblDescrizione10.Visible = true;
                    txtNomeEl5InvNPC.Visible = true;
                    txtDescEl5InvNPC.Visible = true;
                    ddlRacIndEl5InvNPC.Visible = true;
                    btnCreaEl5InvNPC.Visible = true;
                    btnCreaEl5InvNPC.Enabled = true;
                    btnCaricaImgEl5InvNPC.Enabled = true;
                    btnCaricaImgEl5InvNPC.Visible = true;
                    fuEl5InvNPC.Enabled = true;
                    fuEl5InvNPC.Visible = true;
                    imgEl5InvNPC.Visible = true;
                    lblSelezionaSkinNPC5.Visible = true;
                    #endregion
                    break;
            }
            #endregion
        }

        protected void btnCreaEl1InvNPC_Click(object sender, EventArgs e)
        {
            BottElInvNPC(txtNomeEl1InvNPC, txtDescEl1InvNPC, btnCreaEl1InvNPC, ddlRacIndEl1InvNPC, "byteImgEl1NPC", 1);
        }

        protected void btnCreaEl2InvNPC_Click(object sender, EventArgs e)
        {
            BottElInvNPC(txtNomeEl2InvNPC, txtDescEl2InvNPC, btnCreaEl2InvNPC, ddlRacIndEl2InvNPC, "byteImgEl2NPC", 2);
        }

        protected void btnCreaEl3InvNPC_Click(object sender, EventArgs e)
        {
            BottElInvNPC(txtNomeEl3InvNPC, txtDescEl3InvNPC, btnCreaEl3InvNPC, ddlRacIndEl3InvNPC, "byteImgEl3NPC", 3);
        }

        protected void btnCreaEl4InvNPC_Click(object sender, EventArgs e)
        {
            BottElInvNPC(txtNomeEl4InvNPC, txtDescEl4InvNPC, btnCreaEl4InvNPC, ddlRacIndEl4InvNPC, "byteImgEl4NPC", 4);
        }

        protected void btnCreaEl5InvNPC_Click(object sender, EventArgs e)
        {
            BottElInvNPC(txtNomeEl5InvNPC, txtDescEl5InvNPC, btnCreaEl5InvNPC, ddlRacIndEl5InvNPC, "byteImgEl5NPC", 5);
        }

        protected void btnPlayer_Click(object sender, EventArgs e)
        {
            pnNPC.Visible = false;
            pnInventarioNPC.Visible = false;
            btnPlayer.Enabled = false;
            btnPlayer.BackColor = System.Drawing.Color.Red;
            pnPlayer.Visible = true;
            btnCreaPlayer.Enabled = false;
        }

        protected void btnCreaPlayer_Click(object sender, EventArgs e)
        {
            Mappa mappa = (Mappa)Session["mappa"];
            mappa.Player.Nome = txtNomePlayer.Text;
            mappa.Player.Salute = "Buona";
            mappa.Player.Exp = 0;
            mappa.Player.AmbInit = ddlAmbInitPlayer.Text;
            mappa.Player.Skin = (byte[])Session["byteSkinPlayer"];
            Session["mappa"] = mappa;
            #region gestione_interfaccia
            lblNomePlayer.Visible = false;
            lblAmbPartenza.Visible = false;
            lblSelezionaSkinPlayer.Visible = false;
            imgSkin.Visible = false;
            btnEsporta.Visible = true;
            lblErrExport.Visible = true;
            txtNomeFile.Visible = true;
            lblNomePlayer.Visible = true;
            #endregion
        }

        protected void btnCaricaImgAmb_Click(object sender, EventArgs e)
        {
            if (fuAmb.HasFile)
            {
                imgAmb.Visible = true;
                Session["byteImgAmb"] = fuAmb.FileBytes;
                imgAmb.ImageUrl = "data:image;base64," + Convert.ToBase64String((byte[])Session["byteImgAmb"]);
                fuAmb.Enabled = false;
                btnAggiuntaSpecifiche.Enabled = true;
            }
        }

        protected void btnCaricaImgEl1Inv_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl1", fuEl1Inv, imgEl1Inv);
        }

        protected void btnCaricaImgEl2Inv_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl2", fuEl2Inv, imgEl2Inv);
        }

        protected void btnCaricaImgEl3Inv_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl3", fuEl3Inv, imgEl3Inv);
        }

        protected void btnCaricaImgEl4Inv_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl4", fuEl4Inv, imgEl4Inv);
        }

        protected void btnCaricaImgEl5Inv_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl5", fuEl5Inv, imgEl5Inv);
        }

        protected void txtNomeAmb_Load(object sender, EventArgs e)
        {
            txtNomeAmb.Text = "";
        }

        protected void btnCaricaImgEl1InvNPC_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl1NPC", fuEl1InvNPC, imgEl1InvNPC);
        }

        protected void btnCaricaImgEl2InvNPC_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl2NPC", fuEl2InvNPC, imgEl2InvNPC);
        }

        protected void btnCaricaImgEl3InvNPC_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl3NPC", fuEl3InvNPC, imgEl3InvNPC);
        }

        protected void btnCaricaImgEl4InvNPC_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl4NPC", fuEl4InvNPC, imgEl4InvNPC);
        }

        protected void btnCaricaImgEl5InvNPC_Click(object sender, EventArgs e)
        {
            CaricaImgInv("byteImgEl5NPC", fuEl5InvNPC, imgEl5InvNPC);
        }

        protected void btnCaricaImgPlayer_Click(object sender, EventArgs e)
        {
            if (fuPlayer.HasFile)
            {
                imgSkin.Visible = true;
                byte[] b = fuPlayer.FileBytes;
                imgSkin.ImageUrl = "data:image;base64," + Convert.ToBase64String(b);
                Session["byteSkinPlayer"] = b;
                fuPlayer.Enabled = false;
                btnCreaPlayer.Enabled = true;
            }
        }

        protected void btnEsporta_Click(object sender, EventArgs e)
        {
            try
            {
                Mappa mappa = (Mappa)Session["mappa"];
                int h = 0;
                Ambiente[] a = new Ambiente[16];
                for(int i = 0; i < mappa.ambienti.GetLength(0); i++)
                {
                    for(int k = 0; k < mappa.ambienti.GetLength(1); k++)
                    {
                        a[h] = mappa.ambienti[i, k];
                        h++;
                    }
                }
                Mappa mappaVett = new Mappa(a, mappa.Player);
                using (FileStream saveStream =
                    new FileStream((txtNomeFile.Text == "") ? Server.MapPath("~/App_Data/Config.XML") : Server.MapPath($"~/App_Data/{txtNomeFile.Text}.XML"),
                                    FileMode.Create,
                                    FileAccess.Write,
                                    FileShare.None))
                {
                    // Grazie a Indent va anche a capo con i tag.
                    XmlWriterSettings xws = new XmlWriterSettings()
                    {
                        Indent = true
                    };
                    using (XmlWriter xmlWriter =
                            XmlWriter.Create(saveStream, xws))
                    {
                        DataContractSerializer dcSerializer =
                            new DataContractSerializer(typeof(Mappa));
                        dcSerializer.WriteObject(xmlWriter, mappaVett);
                    }
                }
                btnEsporta.Enabled = false;
            }catch(Exception ex)
            {
                lblErrExport.Text = $"Errore nell'esposrtazione: {ex.Message}";
            }
        }
    }
}