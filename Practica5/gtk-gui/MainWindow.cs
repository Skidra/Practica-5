
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button btnSumar;
	private global::Gtk.Button btnDiv;
	private global::Gtk.Button btnMult;
	private global::Gtk.Button btnRestar;
	private global::Gtk.Entry resultado;
	private global::Gtk.Entry numero1;
	private global::Gtk.Entry numero2;
	private global::Gtk.Label lblResultado;
	private global::Gtk.Label lblnum2;
	private global::Gtk.Label lblnum1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnSumar = new global::Gtk.Button ();
		this.btnSumar.CanFocus = true;
		this.btnSumar.Name = "btnSumar";
		this.btnSumar.UseUnderline = true;
		this.btnSumar.Label = global::Mono.Unix.Catalog.GetString ("Sumar");
		this.fixed1.Add (this.btnSumar);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnSumar]));
		w1.X = 16;
		w1.Y = 253;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnDiv = new global::Gtk.Button ();
		this.btnDiv.CanFocus = true;
		this.btnDiv.Name = "btnDiv";
		this.btnDiv.UseUnderline = true;
		this.btnDiv.Label = global::Mono.Unix.Catalog.GetString ("Dividir");
		this.fixed1.Add (this.btnDiv);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnDiv]));
		w2.X = 306;
		w2.Y = 253;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnMult = new global::Gtk.Button ();
		this.btnMult.CanFocus = true;
		this.btnMult.Name = "btnMult";
		this.btnMult.UseUnderline = true;
		this.btnMult.Label = global::Mono.Unix.Catalog.GetString ("Multiplicar");
		this.fixed1.Add (this.btnMult);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnMult]));
		w3.X = 202;
		w3.Y = 253;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnRestar = new global::Gtk.Button ();
		this.btnRestar.CanFocus = true;
		this.btnRestar.Name = "btnRestar";
		this.btnRestar.UseUnderline = true;
		this.btnRestar.Label = global::Mono.Unix.Catalog.GetString ("Restar");
		this.fixed1.Add (this.btnRestar);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnRestar]));
		w4.X = 105;
		w4.Y = 253;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.resultado = new global::Gtk.Entry ();
		this.resultado.CanFocus = true;
		this.resultado.Name = "resultado";
		this.resultado.IsEditable = true;
		this.resultado.InvisibleChar = '●';
		this.fixed1.Add (this.resultado);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.resultado]));
		w5.X = 243;
		w5.Y = 119;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.numero1 = new global::Gtk.Entry ();
		this.numero1.CanFocus = true;
		this.numero1.Name = "numero1";
		this.numero1.IsEditable = true;
		this.numero1.InvisibleChar = '●';
		this.fixed1.Add (this.numero1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.numero1]));
		w6.X = 243;
		w6.Y = 23;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.numero2 = new global::Gtk.Entry ();
		this.numero2.CanFocus = true;
		this.numero2.Name = "numero2";
		this.numero2.IsEditable = true;
		this.numero2.InvisibleChar = '●';
		this.fixed1.Add (this.numero2);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.numero2]));
		w7.X = 244;
		w7.Y = 71;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblResultado = new global::Gtk.Label ();
		this.lblResultado.Name = "lblResultado";
		this.lblResultado.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 3");
		this.fixed1.Add (this.lblResultado);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblResultado]));
		w8.X = 34;
		w8.Y = 125;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblnum2 = new global::Gtk.Label ();
		this.lblnum2.Name = "lblnum2";
		this.lblnum2.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 2");
		this.fixed1.Add (this.lblnum2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblnum2]));
		w9.X = 32;
		w9.Y = 77;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblnum1 = new global::Gtk.Label ();
		this.lblnum1.Name = "lblnum1";
		this.lblnum1.Xalign = 1F;
		this.lblnum1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 1");
		this.fixed1.Add (this.lblnum1);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblnum1]));
		w10.X = 34;
		w10.Y = 28;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 464;
		this.DefaultHeight = 343;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnSumar.Clicked += new global::System.EventHandler (this.OnBtnSumarClicked);
		this.btnDiv.Clicked += new global::System.EventHandler (this.OnBtnDivClicked);
		this.btnMult.Clicked += new global::System.EventHandler (this.OnBtnMultClicked);
		this.btnRestar.Clicked += new global::System.EventHandler (this.OnBtnRestarClicked);
	}
}
