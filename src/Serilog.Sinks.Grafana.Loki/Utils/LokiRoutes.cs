﻿namespace Serilog.Sinks.Grafana.Loki.Utils
{
    internal static class LokiRoutes
    {
        private const string LogEntriesEndpoint = "/loki/api/v1/push";

        public static string BuildLogsEntriesRoute(string host) => $"{host.TrimEnd('/')}{LogEntriesEndpoint}";
    }
}