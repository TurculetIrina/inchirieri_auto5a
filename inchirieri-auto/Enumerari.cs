using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    public enum CuloareMasina
    {
        Alb = 1,
        Negru = 2,
        Albastru = 3,
        Verde = 4,
        Galben = 5,
        Portocaliu = 6
    };

    public enum OptiuniMasina
    {
        AerConditiona = 1,
        Climatizare = 2,
        CutieAutomata = 3,
        CutieManuala = 4,
        GeamuriElectrice = 5,
        Navigatie = 6,
        PilotAutomat = 7,
        Xenon = 8,
        ScauneIncalzite = 9,
        AcoperisPanoramic=10

    };

    public enum CombustibilMasina
    {
        Benzina = 1,
        Diesel = 2,
        ElectricPartial = 3,
        FullElectric=4
    };
}
