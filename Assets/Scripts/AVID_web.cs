using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//AVID_web class: static container for reference to the AVID web
public static class AVID_web
{

    //Sector class: Basic node of AVID web
    public class Sector 
    {
        public Sector opposite;
        public List<Sector> primeLinks;
        public List<Sector> diagLinks;
        public List<Sector> equator;
    }

    //Init(): Builds the AVID web
    public static void Init()
    {
        //North pole
        Sector north90V = new Sector();
        //North 60 degree ring
        Sector north60A = new Sector();
        Sector north60B = new Sector();
        Sector north60C = new Sector();
        Sector north60D = new Sector();
        Sector north60E = new Sector();
        Sector north60F = new Sector();
        //North 30 degree ring
        Sector north30A = new Sector();
        Sector north30AB = new Sector();
        Sector north30B = new Sector();
        Sector north30BC = new Sector();
        Sector north30C = new Sector();
        Sector north30CD = new Sector();
        Sector north30D = new Sector();
        Sector north30DE = new Sector();
        Sector north30E = new Sector();
        Sector north30EF = new Sector();
        Sector north30F = new Sector();
        Sector north30FA = new Sector();
        //Equator
        Sector equator0A = new Sector();
        Sector equator0AB = new Sector();
        Sector equator0B = new Sector();
        Sector equator0BC = new Sector();
        Sector equator0C = new Sector();
        Sector equator0CD = new Sector();
        Sector equator0D = new Sector();
        Sector equator0DE = new Sector();
        Sector equator0E = new Sector();
        Sector equator0EF = new Sector();
        Sector equator0F = new Sector();
        Sector equator0FA = new Sector();
        //South 30 degree ring
        Sector south30A = new Sector();
        Sector south30AB = new Sector();
        Sector south30B = new Sector();
        Sector south30BC = new Sector();
        Sector south30C = new Sector();
        Sector south30CD = new Sector();
        Sector south30D = new Sector();
        Sector south30DE = new Sector();
        Sector south30E = new Sector();
        Sector south30EF = new Sector();
        Sector south30F = new Sector();
        Sector south30FA = new Sector();
        //South 60 degree ring
        Sector south60A = new Sector();
        Sector south60B = new Sector();
        Sector south60C = new Sector();
        Sector south60D = new Sector();
        Sector south60E = new Sector();
        Sector south60F = new Sector();
        //South pole
        Sector south90V = new Sector();

        // Now the hard part - filling out the sectors

        //North pole
        north90V.opposite = south90V;
        north90V.primeLinks = new List<Sector>() {north60A, north60B, north60C, north60D, north60E, north60F};
        north90V.diagLinks = new List<Sector>() {};
        north90V.equator = new List<Sector>() {};

        //North 60 degree ring
        //north60A
        north60A.opposite = south60D;
        north60A.primeLinks = new List<Sector>() {north90V, north60F, north60B, north30AB, north30A, north30FA};
        north60A.diagLinks = new List<Sector>() {};
        north60A.equator = new List<Sector>() {};
        //north60B
        north60B.opposite = south60E;
        north60B.primeLinks = new List<Sector>() {north90V, north60A, north60C, north30AB, north30B, north30BC};
        north60B.diagLinks = new List<Sector>() {};
        north60B.equator = new List<Sector>() {};
        //north60C
        north60C.opposite = south60F;
        north60C.primeLinks = new List<Sector>() {north90V, north60B, north60D, north30BC, north30C, north30CD};
        north60C.diagLinks = new List<Sector>() {};
        north60C.equator = new List<Sector>() {};
        //north60D
        north60D.opposite = south60A;
        north60D.primeLinks = new List<Sector>() {north90V, north60C, north60E, north30CD, north30D, north30DE};
        north60D.diagLinks = new List<Sector>() {};
        north60D.equator = new List<Sector>() {};
        //north60E
        north60E.opposite = south60B;
        north60E.primeLinks = new List<Sector>() {north90V, north60D, north60F, north30DE, north30E, north30EF};
        north60E.diagLinks = new List<Sector>() {};
        north60E.equator = new List<Sector>() {};
        //north60F
        north60F.opposite = south60C;
        north60F.primeLinks = new List<Sector>() {north90V, north60E, north60A, north30EF, north30F, north30FA};
        north60F.diagLinks = new List<Sector>() {};
        north60F.equator = new List<Sector>() {};

        //North 30 degree ring
        //north30A
        north30A.opposite = south30D;
        north30A.primeLinks = new List<Sector>() {north60A, north30FA, north30AB, equator0A};
        north30A.diagLinks = new List<Sector>() {equator0FA, equator0AB};
        north30A.equator = new List<Sector>() {};
        //north30AB
        north30AB.opposite = south30DE;
        north30AB.primeLinks = new List<Sector>() {north60A, north60B, north30A, north30B, equator0AB};
        north30AB.diagLinks = new List<Sector>() {equator0A, equator0B};
        north30AB.equator = new List<Sector>() {};
        //north30B
        north30B.opposite = south30E;
        north30B.primeLinks = new List<Sector>() {north60B, north30AB, north30BC, equator0B};
        north30B.diagLinks = new List<Sector>() {equator0AB, equator0BC};
        north30B.equator = new List<Sector>() {};
        //north30BC
        north30BC.opposite = south30EF;
        north30BC.primeLinks = new List<Sector>() {north60B, north60C, north30B, north30C, equator0BC};
        north30BC.diagLinks = new List<Sector>() {equator0B, equator0C};
        north30BC.equator = new List<Sector>() {};
        //north30C
        north30C.opposite = south30F;
        north30C.primeLinks = new List<Sector>() {north60C, north30BC, north30CD, equator0C};
        north30C.diagLinks = new List<Sector>() {equator0BC, equator0CD};
        north30C.equator = new List<Sector>() {};
        //north30CD
        north30CD.opposite = south30FA;
        north30CD.primeLinks = new List<Sector>() {north60C, north60D, north30C, north30D, equator0CD};
        north30CD.diagLinks = new List<Sector>() {equator0C, equator0D};
        north30CD.equator = new List<Sector>() {};
        //north30D
        north30D.opposite = south30A;
        north30D.primeLinks = new List<Sector>() {north60D, north30CD, north30DE, equator0D};
        north30D.diagLinks = new List<Sector>() {equator0CD, equator0DE};
        north30D.equator = new List<Sector>() {};
        //north30DE
        north30DE.opposite = south30AB;
        north30DE.primeLinks = new List<Sector>() {north60D, north60E, north30D, north30E, equator0DE};
        north30DE.diagLinks = new List<Sector>() {equator0D, equator0E};
        north30DE.equator = new List<Sector>() {};
        //north30E
        north30E.opposite = south30B;
        north30E.primeLinks = new List<Sector>() {north60E, north30DE, north30EF, equator0E};
        north30E.diagLinks = new List<Sector>() {equator0DE, equator0EF};
        north30E.equator = new List<Sector>() {};
        //north30EF
        north30EF.opposite = south30BC;
        north30EF.primeLinks = new List<Sector>() {north60E, north60F, north30E, north30F, equator0EF};
        north30EF.diagLinks = new List<Sector>() {equator0E, equator0F};
        north30EF.equator = new List<Sector>() {};
        //north30F
        north30F.opposite = south30C;
        north30F.primeLinks = new List<Sector>() {north60F, north30EF, north30FA, equator0F};
        north30F.diagLinks = new List<Sector>() {equator0EF, equator0FA};
        north30F.equator = new List<Sector>() {};
        //north30FA
        north30FA.opposite = south30CD;
        north30FA.primeLinks = new List<Sector>() {north60F, north60A, north30F, north30A, equator0FA};
        north30FA.diagLinks = new List<Sector>() {equator0F, equator0A};
        north30FA.equator = new List<Sector>() {};

        //Equator ring
        //equator0A
        equator0A.opposite = equator0D;
        equator0A.primeLinks = new List<Sector>() {north30A, equator0FA, equator0AB, south30A};
        equator0A.diagLinks = new List<Sector>() {north30FA, north30AB, south30FA, south30AB};
        equator0A.equator = new List<Sector>() {};
        //equator0AB
        equator0AB.opposite = equator0DE;
        equator0AB.primeLinks = new List<Sector>() {north30AB, equator0A, equator0B, south30AB};
        equator0AB.diagLinks = new List<Sector>() {north30A, north30B, south30A, south30B};
        equator0AB.equator = new List<Sector>() {};
        //equator0B
        equator0B.opposite = equator0E;
        equator0B.primeLinks = new List<Sector>() {north30B, equator0AB, equator0BC, south30B};
        equator0B.diagLinks = new List<Sector>() {north30AB, north30BC, south30AB, south30BC};
        equator0B.equator = new List<Sector>() {};
        //equator0BC
        equator0BC.opposite = equator0EF;
        equator0BC.primeLinks = new List<Sector>() {north30BC, equator0B, equator0C, south30BC};
        equator0BC.diagLinks = new List<Sector>() {north30B, north30C, south30B, south30C};
        equator0BC.equator = new List<Sector>() {};
        //equator0C
        equator0C.opposite = equator0F;
        equator0C.primeLinks = new List<Sector>() {north30C, equator0BC, equator0CD, south30C};
        equator0C.diagLinks = new List<Sector>() {north30BC, north30CD, south30BC, south30CD};
        equator0C.equator = new List<Sector>() {};
        //equator0CD
        equator0CD.opposite = equator0FA;
        equator0CD.primeLinks = new List<Sector>() {north30CD, equator0C, equator0D, south30CD};
        equator0CD.diagLinks = new List<Sector>() {north30C, north30D, south30C, south30D};
        equator0CD.equator = new List<Sector>() {};
        //equator0D
        equator0D.opposite = equator0A;
        equator0D.primeLinks = new List<Sector>() {north30D, equator0CD, equator0DE, south30D};
        equator0D.diagLinks = new List<Sector>() {north30CD, north30DE, south30CD, south30DE};
        equator0D.equator = new List<Sector>() {};
        //equator0DE
        equator0DE.opposite = equator0AB;
        equator0DE.primeLinks = new List<Sector>() {north30DE, equator0D, equator0E, south30DE};
        equator0DE.diagLinks = new List<Sector>() {north30D, north30E, south30D, south30E};
        equator0DE.equator = new List<Sector>() {};
        //equator0E
        equator0E.opposite = equator0B;
        equator0E.primeLinks = new List<Sector>() {north30E, equator0DE, equator0EF, south30E};
        equator0E.diagLinks = new List<Sector>() {north30DE, north30EF, south30DE, south30EF};
        equator0E.equator = new List<Sector>() {};
        //equator0EF
        equator0EF.opposite = equator0BC;
        equator0EF.primeLinks = new List<Sector>() {north30EF, equator0E, equator0F, south30EF};
        equator0EF.diagLinks = new List<Sector>() {north30E, north30F, south30E, south30F};
        equator0EF.equator = new List<Sector>() {};
        //equator0F
        equator0F.opposite = equator0C;
        equator0F.primeLinks = new List<Sector>() {north30F, equator0EF, equator0FA, south30F};
        equator0F.diagLinks = new List<Sector>() {north30EF, north30FA, south30EF, south30FA};
        equator0F.equator = new List<Sector>() {};
        //equator0FA
        equator0FA.opposite = equator0CD;
        equator0FA.primeLinks = new List<Sector>() {north30FA, equator0F, equator0A, south30FA};
        equator0FA.diagLinks = new List<Sector>() {north30F, north30A, south30F, south30A};
        equator0FA.equator = new List<Sector>() {};

        //South 30 degree ring
        //south30A
        south30A.opposite = north30D;
        south30A.primeLinks = new List<Sector>() {south60A, south30FA, south30AB, equator0A};
        south30A.diagLinks = new List<Sector>() {equator0FA, equator0AB};
        south30A.equator = new List<Sector>() {};
        //south30AB
        south30AB.opposite = north30DE;
        south30AB.primeLinks = new List<Sector>() {south60A, south60B, south30A, south30B, equator0AB};
        south30AB.diagLinks = new List<Sector>() {equator0A, equator0B};
        south30AB.equator = new List<Sector>() {};
        //south30B
        south30B.opposite = north30E;
        south30B.primeLinks = new List<Sector>() {south60B, south30AB, south30BC, equator0B};
        south30B.diagLinks = new List<Sector>() {equator0AB, equator0BC};
        south30B.equator = new List<Sector>() {};
        //south30BC
        south30BC.opposite = north30EF;
        south30BC.primeLinks = new List<Sector>() {south60B, south60C, south30B, south30C, equator0BC};
        south30BC.diagLinks = new List<Sector>() {equator0B, equator0C};
        south30BC.equator = new List<Sector>() {};
        //south30C
        south30C.opposite = north30F;
        south30C.primeLinks = new List<Sector>() {south60C, south30BC, south30CD, equator0C};
        south30C.diagLinks = new List<Sector>() {equator0BC, equator0CD};
        south30C.equator = new List<Sector>() {};
        //south30CD
        south30CD.opposite = north30FA;
        south30CD.primeLinks = new List<Sector>() {south60C, south60D, south30C, south30D, equator0CD};
        south30CD.diagLinks = new List<Sector>() {equator0C, equator0D};
        south30CD.equator = new List<Sector>() {};
        //south30D
        south30D.opposite = north30A;
        south30D.primeLinks = new List<Sector>() {south60D, south30CD, south30DE, equator0D};
        south30D.diagLinks = new List<Sector>() {equator0CD, equator0DE};
        south30D.equator = new List<Sector>() {};
        //south30DE
        south30DE.opposite = north30AB;
        south30DE.primeLinks = new List<Sector>() {south60D, south60E, south30D, south30E, equator0DE};
        south30DE.diagLinks = new List<Sector>() {equator0D, equator0E};
        south30DE.equator = new List<Sector>() {};
        //south30E
        south30E.opposite = north30B;
        south30E.primeLinks = new List<Sector>() {south60E, south30DE, south30EF, equator0E};
        south30E.diagLinks = new List<Sector>() {equator0DE, equator0EF};
        south30E.equator = new List<Sector>() {};
        //south30EF
        south30EF.opposite = north30BC;
        south30EF.primeLinks = new List<Sector>() {south60E, south60F, south30E, south30F, equator0EF};
        south30EF.diagLinks = new List<Sector>() {equator0E, equator0F};
        south30EF.equator = new List<Sector>() {};
        //south30F
        south30F.opposite = north30C;
        south30F.primeLinks = new List<Sector>() {south60F, south30EF, south30FA, equator0F};
        south30F.diagLinks = new List<Sector>() {equator0EF, equator0FA};
        south30F.equator = new List<Sector>() {};
        //south30FA
        south30FA.opposite = north30CD;
        south30FA.primeLinks = new List<Sector>() {south60F, south60A, south30F, south30A, equator0FA};
        south30FA.diagLinks = new List<Sector>() {equator0F, equator0A};
        south30FA.equator = new List<Sector>() {};

        //South 60 degree ring
        //south60A
        south60A.opposite = north60D;
        south60A.primeLinks = new List<Sector>() {south90V, south60F, south60B, south30AB, south30A, south30FA};
        south60A.diagLinks = new List<Sector>() {};
        south60A.equator = new List<Sector>() {};
        //south60B
        south60B.opposite = north60E;
        south60B.primeLinks = new List<Sector>() {south90V, south60A, south60C, south30AB, south30B, south30BC};
        south60B.diagLinks = new List<Sector>() {};
        south60B.equator = new List<Sector>() {};
        //south60C
        south60C.opposite = north60F;
        south60C.primeLinks = new List<Sector>() {south90V, south60B, south60D, south30BC, south30C, south30CD};
        south60C.diagLinks = new List<Sector>() {};
        south60C.equator = new List<Sector>() {};
        //south60D
        south60D.opposite = north60A;
        south60D.primeLinks = new List<Sector>() {south90V, south60C, south60E, south30CD, south30D, south30DE};
        south60D.diagLinks = new List<Sector>() {};
        south60D.equator = new List<Sector>() {};
        //south60E
        south60E.opposite = north60B;
        south60E.primeLinks = new List<Sector>() {south90V, south60D, south60F, south30DE, south30E, south30EF};
        south60E.diagLinks = new List<Sector>() {};
        south60E.equator = new List<Sector>() {};
        //south60F
        south60F.opposite = north60C;
        south60F.primeLinks = new List<Sector>() {south90V, south60E, south60A, south30EF, south30F, south30FA};
        south60F.diagLinks = new List<Sector>() {};
        south60F.equator = new List<Sector>() {};

        //South pole
        south90V.opposite = north90V;
        south90V.primeLinks = new List<Sector>() {south60A, south60B, south60C, south60D, south60E, south60F};
        south90V.diagLinks = new List<Sector>() {};
        south90V.equator = new List<Sector>() {};
    }
}
