using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Poli2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			List<Figura> geoFigure = new List<Figura>();
			geoFigure.Add(new Krug(2));
			geoFigure.Add(new Kvadrat(3));
			geoFigure.Add(new Pravougaonik(2, 3));
			geoFigure.Add(new Pravougaonik(4, 5));
			geoFigure.Add(new Krug(9));
			geoFigure.Add(new Kvadrat(6));

			geoFigure.ForEach(figura => MessageBox.Show($"{figura.ToString()} --  {figura.Povrsina()}"));

		}
	}

	public abstract class Figura
	{
		public int StranaA;
		public abstract double Povrsina();

		public void Foo() => MessageBox.Show("Ovo radi nesto");
	}


	public class Kvadrat : Figura
	{
		public virtual double Povrsina() => StranaA;
		public Kvadrat(int a) => StranaA = a;
	}


	public class Pravougaonik : Kvadrat
	{ 
		public int StranaB;
		public override double Povrsina() => StranaA * StranaB;
		public override string ToString() => "Pravougaonik";
		public Pravougaonik(int a, int b) : base(a) => StranaB = b;
	}

	public class Krug : Figura
	{
		public override double Povrsina() => Math.Pow(StranaA, StranaA) * Math.PI;
		public Krug(int a) => StranaA = a;
	}
}
