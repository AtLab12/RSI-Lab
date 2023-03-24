using System;
using Grpc.Core;
using GPSDistance;

namespace GPSDistance.Services;

public class DistancerService : Distancer.DistancerBase
{
    private double Haversine(double lat1, double lon1, double lat2, double lon2)
    {
        double R = 6371e3;
        double radianLat1 = toRadians(lat1);
        double radianLat2 = toRadians(lat2);
        double deltaLat = toRadians(lat2 - lat1);
        double deltaLon = toRadians(lon2 - lon1);

        double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                   Math.Cos(radianLat1) * Math.Cos(radianLat2) *
                   Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c;
    }

    private double toRadians(double value) {
        return Math.PI / 180.0 * value;
    }

    public override Task<DistancerResponse> CalculateDistance(DistancerRequest request, ServerCallContext context)
    {
        double distanceP1P2 = Haversine(request.Point1.Latitude, request.Point1.Longitude, request.Point2.Latitude, request.Point2.Longitude);

        if (request.Point3 == null)
        {
            return Task.FromResult(new DistancerResponse { Distance = distanceP1P2 });
        }

        double distanceP2P3 = Haversine(request.Point2.Latitude, request.Point2.Longitude, request.Point3.Latitude, request.Point3.Longitude);

        return Task.FromResult(new DistancerResponse { Distance = distanceP1P2 + distanceP2P3 });
    }
}
