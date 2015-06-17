<%@ Page Language="C#" %>
<%@ Import Namespace="System.Drawing" %>
<script runat="server">
    private Color brandColor;
    public void Page_Load(Object sender, EventArgs e) {
        Response.ContentType = "text/css";
        brandColor = Color.FromArgb(0x99, 0x00, 0x33);
    }
</script>

body {
    font-size: 0.8em;
}

h1 {
    color: #<%=brandColor.R.ToString("X2") + brandColor.G.ToString("X2") + brandColor.B.ToString("X2") %>;
}

 