using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnSumarClicked (object sender, EventArgs e)
	{
		int n1= int.Parse(this.numero1.Text);
		int n2= int.Parse(this.numero2.Text);
		int operacion=n1+n2;
		this.resultado.Text=operacion.ToString();
	}

	protected void OnBtnRestarClicked (object sender, EventArgs e)
	{
		int n1= int.Parse(this.numero1.Text);
		int n2= int.Parse(this.numero2.Text);
		int operacion=n1-n2;
		this.resultado.Text=operacion.ToString();
	}

	protected void OnBtnDivClicked (object sender, EventArgs e)
	{
		int n1= int.Parse(this.numero1.Text);
		int n2= int.Parse(this.numero2.Text);
		int operacion=n1/n2;
		this.resultado.Text=operacion.ToString();
	}

	protected void OnBtnMultClicked (object sender, EventArgs e)
	{
		int n1= int.Parse(this.numero1.Text);
		int n2= int.Parse(this.numero2.Text);
		int operacion=n1*n2;
		this.resultado.Text=operacion.ToString();

	}
}

