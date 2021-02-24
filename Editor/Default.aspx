<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Editor.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div style="height: 1901px">
            <asp:Button ID="btnAmbiente" runat="server" Text="Ambiente" OnClick="btnAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInventarioAmbiente" runat="server" Text="Inventario Ambiente" OnClick="btnInventarioAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNPCAmbiente" runat="server" Text="NPC ambiente" OnClick="btnNPCAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnPlayer" runat="server" OnClick="btnPlayer_Click" Text="Player" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <br />
            <asp:Panel ID="pnAmbienteGenerale" runat="server" Width="259px">
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Button ID="btn00" runat="server" Height="60px" OnClick="btn00_Click" Text="0,0" Width="60px" />
                <asp:Button ID="btn01" runat="server" Height="60px" OnClick="btn01_Click" Text="0,1" Width="60px" />
                <asp:Button ID="btn02" runat="server" Height="60px" OnClick="btn02_Click" Text="0,2" Width="60px" />
                <asp:Button ID="btn03" runat="server" Height="60px" OnClick="btn03_Click" Text="0,3" Width="60px" />
                <br />
                <asp:Button ID="btn10" runat="server" Height="60px" OnClick="btn10_Click" Text="1,0" Width="60px" />
                <asp:Button ID="btn11" runat="server" Height="60px" OnClick="btn11_Click" Text="1,1" Width="60px" />
                <asp:Button ID="btn12" runat="server" Height="60px" OnClick="btn12_Click" Text="1,2" Width="60px" />
                <asp:Button ID="btn13" runat="server" Height="60px" OnClick="btn13_Click" Text="1,3" Width="60px" />
                <br />
                <asp:Button ID="btn20" runat="server" Height="60px" OnClick="btn20_Click" Text="2,0" Width="60px" />
                <asp:Button ID="btn21" runat="server" Height="60px" OnClick="btn21_Click" Text="2,1" Width="60px" />
                <asp:Button ID="btn22" runat="server" Height="60px" OnClick="btn22_Click" Text="2,2" Width="60px" />
                <asp:Button ID="btn23" runat="server" Height="60px" OnClick="btn23_Click" Text="2,3" Width="60px" />
                <br />
                <asp:Button ID="btn30" runat="server" Height="60px" OnClick="btn30_Click" Text="3,0" Width="60px" />
                <asp:Button ID="btn31" runat="server" Height="60px" OnClick="btn31_Click" Text="3,1" Width="60px" />
                <asp:Button ID="btn32" runat="server" Height="60px" OnClick="btn32_Click" Text="3,2" Width="60px" />
                <asp:Button ID="btn33" runat="server" Height="60px" OnClick="btn33_Click" Text="3,3" Width="60px" />
                <br />
                <br />
                <asp:Button ID="btnCreaMappa" runat="server" OnClick="btnCreaMappa_Click" Text="Crea mappa" />
            </asp:Panel>
            <br />
            <asp:Panel ID="pnAmbienteSpecifico" runat="server" style="left:300px; width:700px; top:157px; position:absolute; height: 331px; bottom: 399px;">
&nbsp;<asp:Label ID="Label1" runat="server" Text="Nominare ambiente scelto con la ddl"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Text="L. difficoltà"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomeAmb" runat="server"></asp:TextBox>
                <asp:DropDownList ID="ddlScegliAmbiente" runat="server">
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlDifficoltà" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:TextBox ID="txtDescrizioneAmb" runat="server" Height="157px" TextMode="MultiLine" Width="259px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:Image ID="imgAmb" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto;"/>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Scegliere uno sfondo"></asp:Label>
                <br />
                <asp:FileUpload ID="fuAmb" accept="image/*" runat="server" />
                &nbsp;
                <br />
                <asp:Button ID="btnCaricaImgAmb" runat="server" OnClick="btnCaricaImgAmb_Click" Text="Carica sfondo" />
                <br />
                <br />
                <asp:Button ID="btnAggiuntaSpecifiche" runat="server" OnClick="btnAggiuntaSpecifiche_Click" Text="Aggiungi specifiche" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblErrAmb" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="pnInventarioAmbiente" runat="server">
                <asp:Label ID="Label4" runat="server" Text="Seleziona l'ambiente e il numero di elementi da aggiungere"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlInvAmb" runat="server">
                </asp:DropDownList>
                <asp:DropDownList ID="ddlNumElementi" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnNumero" runat="server" Text="Numero elementi inventario" OnClick="btnNumero_Click" />
                <br />
                <br />
                <asp:Label ID="lblNome1" runat="server" Text="Nome" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome2" runat="server" Text="Nome" Visible="False" style="left:320px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome3" runat="server" Text="Nome" Visible="False" style="left:640px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome4" runat="server" Text="Nome" Visible="False" style="left:960px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome5" runat="server" Text="Nome" Visible="False" style="left:1280px; position:absolute;"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomeEl1Inv" runat="server" Visible="False" style="left:10px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl2Inv" runat="server" Visible="False" style="left:320px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl3Inv" runat="server" Visible="False" style="left:640px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl4Inv" runat="server" Visible="False" style="left:960px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl5Inv" runat="server" Visible="False" style="left:1280px; width:242px; position:absolute;"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblDescrizione1" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione2" runat="server" Text="Descrizione" Visible="False" style="left:320px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione3" runat="server" Text="Descrizione" Visible="False" style="left:640px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione4" runat="server" Text="Descrizione" Visible="False" style="left:960px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione5" runat="server" Text="Descrizione" Visible="False" style="left:1280px; position:absolute;"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescEl1Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="188px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl2Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="188px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl3Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="188px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl4Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="188px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl5Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="188px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblSelezionaSkin1" runat="server" Text="Seleziona skin" style="left:10px; width:242px; position:absolute;" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;<asp:Label ID="lblSelezionaSkin2" runat="server" Text="Seleziona skin" style="left:320px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkin3" runat="server" Text="Seleziona skin" style="left:640px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkin4" runat="server" Text="Seleziona skin" style="left:960px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkin5" runat="server" Text="Seleziona skin" style="left:1280px; width:242px; position:absolute;" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:FileUpload ID="fuEl1Inv" runat="server" accept="image/*" style="left:10px; width:242px; position:absolute;" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:FileUpload ID="fuEl2Inv" runat="server" accept="image/*" style="left:320px; width:242px; position:absolute;" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:FileUpload ID="fuEl3Inv" runat="server" accept="image/*" style="left:640px; width:242px; position:absolute;" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:FileUpload ID="fuEl4Inv" runat="server" accept="image/*" style="left:960px; width:242px; position:absolute;" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:FileUpload ID="fuEl5Inv" runat="server" accept="image/*" style="left:1280px; width:242px; position:absolute;" Visible="False" />
                <br />
                <asp:Button ID="btnCaricaImgEl1Inv" runat="server" OnClick="btnCaricaImgEl1Inv_Click" style="left:10px; width: 242px; position:absolute;" Text="Carica sfondo" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCaricaImgEl2Inv" runat="server" OnClick="btnCaricaImgEl2Inv_Click" style="left:320px; width:242px; position:absolute;" Text="Carica sfondo" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCaricaImgEl3Inv" runat="server" OnClick="btnCaricaImgEl3Inv_Click" style="left:640px; width:242px; position:absolute;" Text="Carica sfondo" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCaricaImgEl4Inv" runat="server" OnClick="btnCaricaImgEl4Inv_Click" style="left:960px; width:242px; position:absolute;" Text="Carica sfondo" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCaricaImgEl5Inv" runat="server" OnClick="btnCaricaImgEl5Inv_Click" style="left:1280px; width:242px; position:absolute;" Text="Carica sfondo" Visible="False" />
                <br />
                <asp:DropDownList ID="ddlRacIndEl1Inv" runat="server" style="left:10px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl2Inv" runat="server" style="left:320px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl3Inv" runat="server" style="left:640px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl4Inv" runat="server" style="left:960px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl5Inv" runat="server" style="left:1280px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnCreaEl1Inv" runat="server" OnClick="btnCreaEl1Inv_Click" style="left:10px; width:242px; position:absolute;" Text="Crea elemento" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl2Inv" runat="server" OnClick="btnCreaEl2Inv_Click" style="left:320px; width:242px; position:absolute;" Text="Crea elemento" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl3Inv" runat="server" OnClick="btnCreaEl3Inv_Click" style="left:640px; width:242px; position:absolute;" Text="Crea elemento" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl4Inv" runat="server" OnClick="btnCreaEl4Inv_Click" style="left:960px; width:242px; position:absolute;" Text="Crea elemento" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl5Inv" runat="server" OnClick="btnCreaEl5Inv_Click" style="left:1280px; width:242px; position:absolute;" Text="Crea elemento" Visible="False" />
                <br />
                <br />
                <br />
                <asp:Image ID="imgEl2Inv" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto; left:320px; position:absolute;" Visible="False" />
                <asp:Image ID="imgEl3Inv" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto; left:640px; position:absolute;" Visible="False" />
                <asp:Image ID="imgEl4Inv" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto; left:960px; position:absolute;" Visible="False" />
                <asp:Image ID="imgEl5Inv" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto; left:1280px; position:absolute;" Visible="False" />
                <asp:Image ID="imgEl1Inv" runat="server" BorderStyle="None" style="max-height:150px;max-width:250px;height:auto;width:auto; left:10px; position:absolute; " Visible="False" />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="pnNPC" runat="server">
                <asp:Label ID="Label10" runat="server" Text="Nome NPC"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomeNPC" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Descrizione NPC"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescNPC" runat="server" Height="129px" TextMode="MultiLine" Width="209px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="Ambiente appartenenza"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlAmbNPC" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Text="Salute NPC"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlSaluteNPC" runat="server">
                    <asp:ListItem>Molto buona</asp:ListItem>
                    <asp:ListItem>Buona</asp:ListItem>
                    <asp:ListItem>Stabile</asp:ListItem>
                    <asp:ListItem>Non buona</asp:ListItem>
                    <asp:ListItem>Critica</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label14" runat="server" Text="Esperienza NPC"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlLivelloEsp" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label15" runat="server" Text="Frase che dice l'NPC"></asp:Label>
                <br />
                <asp:TextBox ID="txtFraseNPC" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnCreaNPC" runat="server" OnClick="btnCreaNPC_Click" Text="Crea NPC" />
                &nbsp;<asp:Label ID="lblErrNPC" runat="server"></asp:Label>
            </asp:Panel>
            <br />
            <asp:Panel ID="pnInventarioNPC" runat="server">
                &nbsp;
                <asp:DropDownList ID="ddlNumElementiInvNPC" runat="server">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnNumeroInvNPC" runat="server" Text="Numero elementi inventario" OnClick="btnNumeroInvNPC_Click" />
                <br />
                <br />
                <asp:Label ID="lblNome6" runat="server" Text="Nome" Visible="False" style="left:10px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome7" runat="server" Text="Nome" Visible="False" style="left:320px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome8" runat="server" Text="Nome" Visible="False" style="left:640px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome9" runat="server" Text="Nome" Visible="False" style="left:960px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome10" runat="server" Text="Nome" Visible="False" style="left:1280px; width:242px; position:absolute;"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomeEl1InvNPC" runat="server" Visible="False" style="left:10px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl2InvNPC" runat="server" Visible="False" style="left:320px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl3InvNPC" runat="server" Visible="False" style="left:640px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl4InvNPC" runat="server" Visible="False" style="left:960px; width:242px; position:absolute;"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl5InvNPC" runat="server" Visible="False" style="left:1280px; width:242px; position:absolute;"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblDescrizione6" runat="server" Text="Descrizione" Visible="False" style="left:10px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione7" runat="server" Text="Descrizione" Visible="False" style="left:320px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione8" runat="server" Text="Descrizione" Visible="False" style="left:640px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione9" runat="server" Text="Descrizione" Visible="False" style="left:960px; width:242px; position:absolute;"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione10" runat="server" Text="Descrizione" Visible="False" style="left:1280px; width:242px; position:absolute;"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescEl1InvNPC" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl2InvNPC" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl3InvNPC" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl4InvNPC" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl5InvNPC" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblSelezionaSkinNPC1" runat="server" Text="Seleziona skin" style="left:10px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkinNPC2" runat="server" Text="Seleziona skin" style="left:320px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkinNPC3" runat="server" Text="Seleziona skin" style="left:640px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkinNPC4" runat="server" Text="Seleziona skin" style="left:960px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <asp:Label ID="lblSelezionaSkinNPC5" runat="server" Text="Seleziona skin" style="left:1280px; width:242px; position:absolute;" Visible="False"></asp:Label>
                <br />
                <asp:FileUpload ID="fuEl1InvNPC" accept="image/*" runat="server" style="left:10px; width:242px; position:absolute;" Visible="False" />
                <asp:FileUpload ID="fuEl2InvNPC" accept="image/*" runat="server" style="left:320px; width:242px; position:absolute;" Visible="False" />
                <asp:FileUpload ID="fuEl3InvNPC" accept="image/*" runat="server" style="left:640px; width:242px; position:absolute;" Visible="False" />
                <asp:FileUpload ID="fuEl4InvNPC" accept="image/*" runat="server" style="left:960px; width:242px; position:absolute;" Visible="False" />
                <asp:FileUpload ID="fuEl5InvNPC" accept="image/*" runat="server" style="left:1280px; width:242px; position:absolute;" Visible="False" />
                <br />
                <asp:Button ID="btnCaricaImgEl1InvNPC" runat="server" Text="Carica immagine" style="left:10px; width:242px; position:absolute;" OnClick="btnCaricaImgEl1InvNPC_Click" Visible="False"/>
                <asp:Button ID="btnCaricaImgEl2InvNPC" runat="server" Text="Carica immagine" style="left:320px; width:242px; position:absolute;" OnClick="btnCaricaImgEl2InvNPC_Click" Visible="False"/>
                <asp:Button ID="btnCaricaImgEl3InvNPC" runat="server" Text="Carica immagine" style="left:640px; width:242px; position:absolute;" OnClick="btnCaricaImgEl3InvNPC_Click" Visible="False"/>
                <asp:Button ID="btnCaricaImgEl4InvNPC" runat="server" Text="Carica immagine" style="left:960px; width:242px; position:absolute;" OnClick="btnCaricaImgEl4InvNPC_Click" Visible="False"/>
                <asp:Button ID="btnCaricaImgEl5InvNPC" runat="server" Text="Carica immagine" style="left:1280px; width:242px; position:absolute;" OnClick="btnCaricaImgEl5InvNPC_Click" Visible="False"/>
                <br />
                <asp:DropDownList ID="ddlRacIndEl1InvNPC" runat="server" style="left:10px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Indossabile</asp:ListItem>
                    <asp:ListItem>Arma</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl2InvNPC" runat="server" style="left:320px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Indossabile</asp:ListItem>
                    <asp:ListItem>Arma</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl3InvNPC" runat="server" style="left:640px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Indossabile</asp:ListItem>
                    <asp:ListItem>Arma</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl4InvNPC" runat="server" style="left:960px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Indossabile</asp:ListItem>
                    <asp:ListItem>Arma</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl5InvNPC" runat="server" style="left:1280px; width:242px; position:absolute;" Visible="False">
                    <asp:ListItem>Indossabile</asp:ListItem>
                    <asp:ListItem>Arma</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnCreaEl1InvNPC" runat="server" OnClick="btnCreaEl1InvNPC_Click" Text="Crea elemento" Visible="False" style="left:10px; width:242px; position:absolute;"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl2InvNPC" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl2InvNPC_Click" style="left:320px; width:242px; position:absolute;"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl3InvNPC" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl3InvNPC_Click" style="left:640px; width:242px; position:absolute;"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl4InvNPC" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl4InvNPC_Click" style="left:960px; width:242px; position:absolute;"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl5InvNPC" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl5InvNPC_Click" style="left:1280px; width:242px; position:absolute;"/>
                <br />
                <br />
                <asp:Image ID="imgEl1InvNPC" runat="server" style="left:0px; position:absolute;"/>
                <asp:Image ID="imgEl2InvNPC" runat="server" style="left:320px; position:absolute;"/>
                <asp:Image ID="imgEl3InvNPC" runat="server" style="left:640px; position:absolute;"/>
                <asp:Image ID="imgEl4InvNPC" runat="server" style="left:960px; position:absolute;"/>
                <asp:Image ID="imgEl5InvNPC" runat="server" style="left:1280px; position:absolute;"/>
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="pnPlayer" runat="server" style="margin-bottom: 0px">
                <asp:Label ID="lblNomePlayer" runat="server" Text="Nome player"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomePlayer" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblAmbPartenza" runat="server" Text="Ambiente di partenza"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlAmbInitPlayer" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="lblSelezionaSkinPlayer" runat="server" Text="Seleziona skin"></asp:Label>
                <br />
                <asp:FileUpload ID="fuPlayer" accept="image/*" runat="server" style="left:10px; width:242px; position:absolute;" />
                <br />
                <asp:Button ID="btnCaricaImgPlayer" runat="server" OnClick="btnCaricaImgPlayer_Click" style="left:10px; width:242px; position:absolute;" Text="Carica skin" />
                <br />
                <br />
                <asp:Button ID="btnCreaPlayer" runat="server" OnClick="btnCreaPlayer_Click" style="left:10px; width:242px; position:absolute;" Text="Crea Player" />
                <br />
                <asp:Label ID="lblNomeFile" runat="server" Text="Nomina il file da esportare" style="left:385px; position:absolute;" Visible="False"></asp:Label>
                <br />
                <asp:Image ID="imgSkin" runat="server" style="left:10px; position:absolute;" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnEsporta" runat="server" Text="Esporta configrazione" style="left:640px; width:242px; position:absolute; " OnClick="btnEsporta_Click" Visible="False" />
                <asp:Label ID="lblErrExport" runat="server" style="left:900px; position:absolute; top: 2899px;" Visible="False"></asp:Label>
                <asp:TextBox ID="txtNomeFile" runat="server" style="left:385px; width:242px; position:absolute;" Visible="False"></asp:TextBox>
                <br />
            </asp:Panel>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
