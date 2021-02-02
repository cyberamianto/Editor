<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Editor.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAmbiente" runat="server" Text="Ambiente" OnClick="btnAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInventarioAmbiente" runat="server" Text="Inventario Ambiente" OnClick="btnInventarioAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnNPCAmbiente" runat="server" Text="NPC ambiente" OnClick="btnNPCAmbiente_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInventarioNPC" runat="server" Text="Inventario NPC" />
            <br />
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
            <br />
            <asp:Panel ID="pnAmbienteGenerale" runat="server">
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
            <asp:Panel ID="pnAmbienteSpecifico" runat="server">
                <asp:DropDownList ID="ddlScegliAmbiente" runat="server">
                </asp:DropDownList>
                <br />
                <br />
                <asp:TextBox ID="txtNomeAmb" runat="server"></asp:TextBox>
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
                <br />
                <br />
                <br />
                <asp:Button ID="btnAggiuntaSpecifiche" runat="server" OnClick="btnAggiuntaSpecifiche_Click" Text="Aggiungi specifiche" />
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="pnInventarioAmbiente" runat="server">
                &nbsp;
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
                <asp:Label ID="lblNome2" runat="server" Text="Nome" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome3" runat="server" Text="Nome" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome4" runat="server" Text="Nome" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblNome5" runat="server" Text="Nome" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtNomeEl1Inv" runat="server" Visible="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl2Inv" runat="server" Visible="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl3Inv" runat="server" Visible="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl4Inv" runat="server" Visible="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtNomeEl5Inv" runat="server" Visible="False"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblDescrizione1" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione2" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione3" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione4" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblDescrizione5" runat="server" Text="Descrizione" Visible="False"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescEl1Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl2Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl3Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl4Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtDescEl5Inv" runat="server" Height="167px" TextMode="MultiLine" Visible="False" Width="202px"></asp:TextBox>
                <br />
                <br />
                <asp:DropDownList ID="ddlRacIndEl1Inv" runat="server" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl2Inv" runat="server" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl3Inv" runat="server" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl4Inv" runat="server" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlRacIndEl5Inv" runat="server" Visible="False">
                    <asp:ListItem>Strutturale</asp:ListItem>
                    <asp:ListItem>Raccoglibile</asp:ListItem>
                    <asp:ListItem>Raccoglibile-Indossabile</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnCreaEl1Inv" runat="server" OnClick="btnCreaEl1Inv_Click" Text="Crea elemento" Visible="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl2Inv" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl2Inv_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl3Inv" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl3Inv_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl4Inv" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl4Inv_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCreaEl5Inv" runat="server" Text="Crea elemento" Visible="False" OnClick="btnCreaEl5Inv_Click" />
                <br />
                <br />
                <br />
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="pnNPC" runat="server">
                <asp:TextBox ID="txtNomeNPC" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtDescNPC" runat="server" Height="129px" TextMode="MultiLine" Width="209px"></asp:TextBox>
                <br />
                <asp:DropDownList ID="ddlAmbNPC" runat="server">
                </asp:DropDownList>
                <br />
                <asp:DropDownList ID="ddlSaluteNPC" runat="server">
                    <asp:ListItem>Molto buona</asp:ListItem>
                    <asp:ListItem>Buona</asp:ListItem>
                    <asp:ListItem>Stabile</asp:ListItem>
                    <asp:ListItem>Non buona</asp:ListItem>
                    <asp:ListItem>Critica</asp:ListItem>
                </asp:DropDownList>
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
                <asp:Button ID="btnCreaNPC" runat="server" OnClick="btnCreaNPC_Click" Text="Crea NPC" />
            </asp:Panel>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
