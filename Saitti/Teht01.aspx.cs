using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teht01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void laskehinta(object sender, EventArgs e)
    {
        int LasinNelioHinta = 45;
        int AlumiiniKarminJuoksumetriHinta = 100;
        int Tyomenekki = 150;

        double input_l = Convert.ToDouble(L.Text) / 1000;
        double input_h = Convert.ToDouble(H.Text) / 1000;
        double input_w = Convert.ToDouble(W.Text) / 1000;

        var ala = input_l * input_h;
        var kpiiri = ((2* input_l) + (2* input_h)) - (4* input_w);
        var hinta = 1.30 * ((ala * LasinNelioHinta) + (kpiiri * AlumiiniKarminJuoksumetriHinta) + Tyomenekki);

        pinta_ala.Text = ala.ToString() + " m2";
        karmin_piiri.Text = kpiiri.ToString() + " m";
        loppuhinta.Text = hinta.ToString() + " e";
           


        // luetaan käyttäjän antama syöte
        //string inPut = "Terve: " + txtNimi.Text;
        // näytetään käyttäjälle
        //lblTulos.Text = inPut;
    }
}