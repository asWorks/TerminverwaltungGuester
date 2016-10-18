using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using Termineverwaltung.Data;


namespace Terminverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new PhysioDataModel())
            {
                //var x = new Mitarbeiter { Nachname = "Henkel", Vorname = "Anja", IstBehandler = true, Geburtsdatum = new DateTime(1985, 1, 1) };
                //db.Mitarbeiter.Add(x);

                //var t = new Patiententermin
                //{
                //    Termin = new DateTime(2016, 11, 1, 11, 10, 0),
                //    Dauer = new TimeSpan(0, 25, 0),
                //    Behandler = x

                //};

                //db.Termine.Add(t);
                //db.SaveChanges();

                var x = db.Mitarbeiter.Where(f => f.Id == 3).Include(p => p.Termine).SingleOrDefault();

                var datum = new DateTime(2016, 11, 1, 11, 10, 0);
                for (int i = 0; i < 10; i++)
                {

                    datum = datum + new TimeSpan(0, 25, 0);
                    var t = new Patiententermin
                    {

                        Termin = datum,
                        Dauer = new TimeSpan(0, 25, 0),
                        Behandler = x

                    };

                    db.Termine.Add(t);
                }


                if (x.Nachname.Length > 0)
                    Console.WriteLine(x.Nachname);

                db.SaveChanges();


            }
        }
    }
}
