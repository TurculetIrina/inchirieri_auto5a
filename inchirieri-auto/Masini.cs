using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Masini
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public string NumarDeInmatriculare { get; set; }
        public int AnFabricatie { get; set; }
        public int CapacitateMotor { get; set; }
        public bool Inchiriata { get; set; }

        public CuloareMasina Culoare { get; set; }
        public CombustibilMasina Combustibil { get; set; }
        public OptiuniMasina[] Optiuni;

        public Masini()
        {
            Marca = Model = NumarDeInmatriculare = string.Empty;
            AnFabricatie = CapacitateMotor = 0;
            Inchiriata = false;
        }

        public Masini(string _marca, string _model, string _numar, 
            int _an_fabricatie, int _capacitate_motor, CuloareMasina _culoare, 
            CombustibilMasina _combustibil, bool _inchiriata)
        {
            Marca = _marca;
            Model = _model;
            NumarDeInmatriculare = _numar;
            AnFabricatie = _an_fabricatie;
            CapacitateMotor = _capacitate_motor;
            Culoare = _culoare;
            Combustibil = _combustibil;
            //Optiuni = _optiuni;
            Inchiriata = _inchiriata;
        }

        public Masini(string linie)
        {
            string[] date = linie.Split(',');
            Marca = date[0];
            Model = date[1];
            NumarDeInmatriculare = date[2];
            AnFabricatie = System.Convert.ToInt32(date[3]);
            CapacitateMotor = System.Convert.ToInt32(date[4]);
            Culoare = (CuloareMasina)Enum.Parse(typeof(CuloareMasina), date[5]);
            Combustibil = (CombustibilMasina)Enum.Parse(typeof(CombustibilMasina), date[6]);
            //Optiuni = _optiuni;
        }

        public string ConversieLaSir()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}\n", 
                Marca, Model, NumarDeInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil);
        }

        public string ConversieLaSirFisier()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                Marca, Model, NumarDeInmatriculare, AnFabricatie, CapacitateMotor, Culoare, Combustibil);
        }

        public bool Compare(Masini masina)
        {
            if (NumarDeInmatriculare == masina.NumarDeInmatriculare)
                return true;
            return false;
        }
    }
}
