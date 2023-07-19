﻿namespace ExtraDrug.Helpers;

public class LocationHelper
{
    public double toRadians(double angleIn10thofaDegree)
    {
        // Angle in 10th of a degree
        return (angleIn10thofaDegree * Math.PI) / 180;
    }
    public double distance(double lat1, double lat2,double lon1,double lon2)
    {
        lon1 = toRadians(lon1);
        lon2 = toRadians(lon2);
        lat1 = toRadians(lat1);
        lat2 = toRadians(lat2);

        // Haversine formula
        double dlon = lon2 - lon1;
        double dlat = lat2 - lat1;
        double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                   Math.Cos(lat1) * Math.Cos(lat2) *
                   Math.Pow(Math.Sin(dlon / 2), 2);

        double c = 2 * Math.Asin(Math.Sqrt(a));

        double r = 6371;

        return Math.Round(c * r);
    }

}