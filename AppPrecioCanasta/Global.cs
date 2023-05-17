using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPrecioCanasta
{
    class Global
    {
        private static List<Mes> a2005 = new List<Mes>{
            new Mes("Enero",1504.1,916.9,142.8),
            new Mes("Febrero",1508.8,913,143.8),
            new Mes("Marzo",1514.5,919.3,144.3),
            new Mes("Abril",1556.3,1003.9,146.2),
            new Mes("Mayo",1592.6,927.1,146.6),
            new Mes("Junio",1597,925.4,147.1),
            new Mes("Julio",1611.1,931.8,147.9),
            new Mes("Agosto",1605.2,946,148.2),
            new Mes("Septiembre",1608.7,952,148.7),
            new Mes("Octubre",1631.2,969.2,149.2),
            new Mes("Noviembre",1680.8,968.1,149.3),
            new Mes("Diciembre",1679.3,964.1,151.4)
        };

        private static List<Mes> a2006 = new List<Mes> {
            new Mes("Enero",1687.2,970.3,152.6),
            new Mes("Febrero",1691.6,967.4,153.4),
            new Mes("Marzo",1719,960,154.6),
            new Mes("Abril",1728,964.4,154.8),
            new Mes("Mayo",1733.9,1063.8,157.1),
            new Mes("Junio",1740.3,1069.6,158.8),
            new Mes("Julio",1732.8,1077.8,160.1),
            new Mes("Agosto",1740.8,1085.8,161.1),
            new Mes("Septiembre",1745.5,1083.7,163.4),
            new Mes("Octubre",1758.6,1076.5,163.9),
            new Mes("Noviembre",1797,1066.1,166.1),
            new Mes("Diciembre",1852.7,1026.8,166.9)
        };

        private static List<Mes> a2007 = new List<Mes> {
            new Mes("Enero",1876.2,1001.4,168.4),
            new Mes("Febrero",1909,1002.6,169.5),
            new Mes("Marzo",1910.6,1010.4,172.3),
            new Mes("Abril",1925.3,1019.3,174.5),
            new Mes("Mayo",1909.4,1030.8,174.8),
            new Mes("Junio",1967.8,1038.3,175.6),
            new Mes("Julio",2001.6,1039.8,176.8),
            new Mes("Agosto",2030.2,1045.8,178.6),
            new Mes("Septiembre",4198.5,2331.3,687.5),
            new Mes("Octubre",4398.6,2347.8,692.1),
            new Mes("Noviembre",4730.6,2351.4,704.5),
            new Mes("Diciembre",4647.2,2366.3,700.4)
        };

        private static List<Mes> a2008 = new List<Mes>
        {
            new Mes("Enero",4690.5, 2375.3, 711.1),
            new Mes("Febrero",4775.5, 2380.5, 718.4),
            new Mes("Marzo",4820.7, 2384.8, 721.3),
            new Mes("Abril",4903.4, 2400.2, 726),
            new Mes("Mayo",5179.3, 2420.1, 731.9),
            new Mes("Junio",5452, 2442.5, 741.9),
            new Mes("Julio",5469.6, 2470.2, 747.7),
            new Mes("Agosto",5444, 2472.9, 758),
            new Mes("Septiembre",5391.4, 2464.4, 761.6),
            new Mes("Octubre",5509.2, 2451.2, 766.2),
            new Mes("Noviembre",5672.6, 2403.3, 781.5),
            new Mes("Diciembre",5650.7, 2375.3, 792.4)
        };

        private static List<Mes> a2009 = new List<Mes>
        {
            new Mes("Enero", 5532.6, 2373, 796.9),
            new Mes("Febrero", 5424.3, 2391.5, 807.7),
            new Mes("Marzo", 5352.4, 2385.7, 809.5),
            new Mes("Abril", 5186.1, 2390.5, 815.2),
            new Mes("Mayo", 5273.6, 2393.5, 818.5),
            new Mes("Junio", 5193.6, 2407, 823.1),
            new Mes("Julio", 5119.2, 2422.3, 824.4),
            new Mes("Agosto", 5085.6, 2419.8, 831.6),
            new Mes("Septiembre", 5056.3, 2435.8, 837),
            new Mes("Octubre", 5117.1, 2441.8, 839.2),
            new Mes("Noviembre", 5029.8, 2455.3, 844),
            new Mes("Diciembre", 5016.7, 2466.1, 846.8)
        };

        private static List<Mes> a2010 = new List<Mes>
        {
            new Mes("Enero", 5037.6, 2497.3, 856.7),
            new Mes("Febrero", 5225, 2511.2, 862.6),
            new Mes("Marzo", 5279.6, 2511.7, 867.1),
            new Mes("Abril", 5294.2, 2507.3, 868.7),
            new Mes("Mayo", 5298, 2507.4, 870.7),
            new Mes("Junio", 5411.3, 2503.5, 871.2),
            new Mes("Julio", 5629.8, 2499.4, 872.7),
            new Mes("Agosto", 5276.5, 2502.2, 876.4),
            new Mes("Septiembre", 5327.3, 2510.1, 881.1),
            new Mes("Octubre", 5856.9, 2524.6, 885.6),
            new Mes("Noviembre", 6067.8, 2542.6, 897.4),
            new Mes("Diciembre", 5876.4, 2558.2, 911.2)
        };

        private static List<Mes> a2011 = new List<Mes> 
        {
            new Mes("Enero", 5790, 2574.6, 920.2),
            new Mes("Febrero", 5786.7, 2588.6, 926),
            new Mes("Marzo", 5808.5, 2596.5, 935.2),
            new Mes("Abril", 5897.6, 2609, 948.2),
            new Mes("Mayo", 5982.4, 2626.3, 976.3),
            new Mes("Junio", 6236.5, 2633.1, 992.8),
            new Mes("Julio", 6197.5, 2635.4, 1009.7),
            new Mes("Agosto", 6196.6, 2642.3, 1017.9),
            new Mes("Septiembre", 6076.3, 2649.9, 1028.4),
            new Mes("Octubre", 6147.5, 2656.5, 1047.9),
            new Mes("Noviembre", 6302.2, 2653.5, 1057.1),
            new Mes("Diciembre", 6395.2, 2656.9, 1083.9)
        };

        private static List<Mes> a2012 = new List<Mes> 
        {
            new Mes("Enero", 6360.9, 2663.8, 1096.8),
            new Mes("Febrero", 6311.4, 2654.4, 1103.5),
            new Mes("Marzo", 6327.3, 2654.4, 1110.7),
            new Mes("Abril", 6563.9, 2660.9, 1124.9),
            new Mes("Mayo", 6494.7, 2653.7, 1130.1),
            new Mes("Junio", 6512.1, 2619, 1129.4),
            new Mes("Julio", 6578.4, 2610.8, 1145.9),
            new Mes("Agosto", 6422.3, 2623.7, 1157.9),
            new Mes("Septiembre", 6573.7, 2636.5, 1167.5),
            new Mes("Octubre", 6658, 2639.6, 1173.5),
            new Mes("Noviembre", 6735.8, 2647.2, 1187.6),
            new Mes("Diciembre", 6990.8, 2645.6, 1208.4)
        };

        private static List<Mes> a2013 = new List<Mes> 
        {
            new Mes("Enero", 6995.6, 2650.2, 1218.4),
            new Mes("Febrero", 6946.9, 2658.1, 1231.2),
            new Mes("Marzo", 6887.2, 2659.4, 1238.1),
            new Mes("Abril", 6959.4, 2657.4, 1246.6),
            new Mes("Mayo", 7092.1, 2662.6, 1248.2),
            new Mes("Junio", 7377.6, 2662, 1258.7),
            new Mes("Julio", 7165.1, 2654.6, 1263.3),
            new Mes("Agosto", 7105.4, 2670.2, 1268.2),
            new Mes("Septiembre", 7029, 2692.8, 1269.2),
            new Mes("Octubre", 6943.4, 2714.1, 1273.5),
            new Mes("Noviembre", 6993.7, 2723.9, 1279.6),
            new Mes("Diciembre", 7027.1, 2730.9, 1285.1)
        };

        private static List<Mes> a2014 = new List<Mes> 
        {
            new Mes("Enero", 7271.1, 2741.6, 1283.2),
            new Mes("Febrero", 7273.4, 2767.7, 1283.4),
            new Mes("Marzo", 7234.5, 2752.7, 1284.6),
            new Mes("Abril", 7400, 2725.5, 1285.2),
            new Mes("Mayo", 7694.5, 2728.4, 1290.9),
            new Mes("Junio", 8220.5, 2727.5, 1311.2),
            new Mes("Julio", 8401, 2734, 1305.9),
            new Mes("Agosto", 8473.3, 2736.5, 1318.7),
            new Mes("Septiembre", 8159.5, 2736, 1324.9),
            new Mes("Octubre", 8011.9, 2745.2, 1331.5),
            new Mes("Noviembre", 8327.2, 2728.1, 1332.7),
            new Mes("Diciembre", 8216.7, 2697.8, 1339.1)
        };

        private static List<Mes> a2015 = new List<Mes> 
        {
            new Mes("Enero", 8242.7, 2679.7, 1345.1),
            new Mes("Febrero", 8143.4, 2690.2, 1351.1),
            new Mes("Marzo", 8070.9, 2699.7, 1356.3),
            new Mes("Abril", 8089.1, 2677.2, 1359.9),
            new Mes("Mayo", 8196.2, 2679.3, 1364.5),
            new Mes("Junio", 8243.3, 2664.1, 1370.3),
            new Mes("Julio", 8302.3, 2657.4, 1373.3),
            new Mes("Agosto", 8272.9, 2662.9, 1384.6),
            new Mes("Septiembre", 8166.3, 2666, 1390.9),
            new Mes("Octubre", 8278.9, 2677.4, 1388.2),
            new Mes("Noviembre", 8283.8, 2678.8, 1393.2),
            new Mes("Diciembre", 8274.4, 2695.6, 1394.5)
        };

        private static List<Mes> a2016 = new List<Mes> 
        {
            new Mes("Enero", 8262.7, 2691.2, 1403.4),
            new Mes("Febrero", 8348.3, 2680.3, 1416.5),
            new Mes("Marzo", 8534, 2685.6, 1421.9),
            new Mes("Abril", 8489.9, 2692.6, 1436.7),
            new Mes("Mayo", 8610.2, 2700.6, 1457),
            new Mes("Junio", 8557, 2711.9, 1466.3),
            new Mes("Julio", 8697.3, 2713.2, 1482),
            new Mes("Agosto", 8460.5, 2709.6, 1497.1),
            new Mes("Septiembre", 8239.1, 2706.9, 1506.8),
            new Mes("Octubre", 8131, 2720.7, 1514.9),
            new Mes("Noviembre", 8206.4, 2732.6, 1519.3),
            new Mes("Diciembre", 8266.3, 2732.5, 1527.8)
        };

        private static List<Mes> a2017 = new List<Mes> 
        {
            new Mes("Enero", 8396.3, 2779.7, 1538.9),
            new Mes("Febrero", 8419.9, 2801.1, 1543.9),
            new Mes("Marzo", 8449.4, 2795.4, 1548.3),
            new Mes("Abril", 8466.1, 2769.3, 1546.8),
            new Mes("Mayo", 8600.7, 2776.3, 1552.6),
            new Mes("Junio", 8444.8, 2787.1, 1554.4),
            new Mes("Julio", 8437.3, 2783.9, 1559.7),
            new Mes("Agosto", 8322.1, 2807.9, 1566.6),
            new Mes("Septiembre", 8365.4, 2831.3, 1584.8),
            new Mes("Octubre", 8480.1, 2853.6, 1588.2),
            new Mes("Noviembre", 8733.9, 2861, 1592.4),
            new Mes("Diciembre", 8874, 2870.2, 1587.8)
        };

        private static List<Mes> a2018 = new List<Mes> 
        {
            new Mes("Enero", 8932.1, 2873.7, 1591.1),
            new Mes("Febrero", 8873.1, 2865.7, 1599.4),
            new Mes("Marzo", 8797.4, 2873.8, 1602.8),
            new Mes("Abril", 8796.4, 2873.1, 1605),
            new Mes("Mayo", 8934.9, 2880.1, 1607.6),
            new Mes("Junio", 9073.5, 2886, 1615.4),
            new Mes("Julio", 9087, 2892, 1620.9),
            new Mes("Agosto", 8976.7, 2890.5, 1626.4),
            new Mes("Septiembre", 8868.8, 2934.3, 1625.3),
            new Mes("Octubre", 8860.8, 2953.1, 1626.2),
            new Mes("Noviembre", 8943.6, 2967.9, 1628.7),
            new Mes("Diciembre", 8972.6, 2955.6, 1636.5)
        };

        private static List<Mes> a2019 = new List<Mes> 
        {
            new Mes("2019", 9122.5, 2977.7, 1685.8),
            new Mes("Enero", 8935.9, 2918.8, 1646.2),
            new Mes("Febrero", 8822.9, 2924.5, 1667.4),
            new Mes("Marzo", 8982, 2993.6, 1685),
            new Mes("Abril", 9080.1, 3004.7, 1696),
            new Mes("Mayo", 9187, 3015, 1699.2),
            new Mes("Junio", 9377.3, 3004.1, 1703),
            new Mes("Julio", 9472.3, 2983.5, 1704),
            null,
            null,
            null,
            null
        };


        public static List<Anio> años = new List<Anio>
        {
            new Anio(1994,635.7,249,86, null),
            new Anio(1995,711.4,279.3,88.2, null),
            new Anio(1996,809.7,330.7,85.1, null),
            new Anio(1997,896.2,433.8,72.9, null),
            new Anio(1998,1004.4,496.5,77.3, null),
            new Anio(1999,1043.1,563.6,87.4, null),
            new Anio(2000,1076.3,683.5,92.6, null),
            new Anio(2001,1170.2,710,100, null),
            new Anio(2002,1242.1,725.1,110.9, null),
            new Anio(2003,1274.6,807.6,126.8, null),
            new Anio(2004,1429,899.6,136, null),
            new Anio(2005,1590.8,944.7,147.1, a2005),
            new Anio(2006,1744,1034.3,159.4, a2006),
            new Anio(2007,2792.1,1465.4,347.9, a2007),
            new Anio(2008,5246.6,2420.1,746.5, a2008),
            new Anio(2009,5198.9,2415.2,824.5, a2009),
            new Anio(2010,5465,2514.6,876.8, a2010),
            new Anio(2011,6068.1,2626.9,995.3, a2011),
            new Anio(2012,6544.1,2642.5,1144.7, a2012),
            new Anio(2013,7043.5,2678,1256.7, a2013),
            new Anio(2014,7890.3,2735.1,1307.6, a2014),
            new Anio(2015,8213.7,2677.4,1372.7, a2015),
            new Anio(2016,8400.2,2706.5,1470.8, a2016),
            new Anio(2017,8499.2,2809.7,1563.7, a2017),
            new Anio(2018,8926.4,2903.8,1615.4, a2018),
            new Anio(2019,9122.5,2977.7,1685.8, a2019)
        };

        public class Anio
        {
            int año;
            double cAlimentos, cHogar, cVestuario;
            List<Mes> meses;

            public Anio(int año, double cAlimentos, double cHogar, double cVestuario, List<Mes> meses)
            {
                this.Año = año;
                this.CAlimentos = cAlimentos;
                this.CHogar = cHogar;
                this.CVestuario = cVestuario;
                this.Meses = meses;
            }

            public int Año { get => año; set => año = value; }
            public double CAlimentos { get => cAlimentos; set => cAlimentos = value; }
            public double CHogar { get => cHogar; set => cHogar = value; }
            public double CVestuario { get => cVestuario; set => cVestuario = value; }
            internal List<Mes> Meses { get => meses; set => meses = value; }
        }

        public class Mes
        {
            string nombre;
            double cAlimentos, cHogar, cVestuario;

            public Mes(string nombre, double cAlimentos, double cHogar, double cVestuario)
            {
                this.Nombre = nombre;
                this.CAlimentos = cAlimentos;
                this.CHogar = cHogar;
                this.CVestuario = cVestuario;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public double CAlimentos { get => cAlimentos; set => cAlimentos = value; }
            public double CHogar { get => cHogar; set => cHogar = value; }
            public double CVestuario { get => cVestuario; set => cVestuario = value; }
        }
    }
}