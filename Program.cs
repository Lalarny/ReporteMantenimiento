using System;                     

namespace ReporteMantenimiento 
{
    class Program            
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("===== REPORTE DE MANTENIMIENTO =====");
            Console.WriteLine($"Equipo: {Environment.MachineName}");
            Console.WriteLine($"Usuario: {Environment.UserName}");
            Console.WriteLine($"Sistema: {Environment.OSVersion}");
            Console.WriteLine($"Fecha: {DateTime.Now}");

            Console.WriteLine("---- DISCOS ----");
            foreach(DriveInfo disco in DriveInfo.GetDrives())
            {
                double libreGB = disco.AvailableFreeSpace / 1024.0 / 1024 / 1024;
                double totalGB = disco.TotalSize / 1024.0 / 1024 / 1024;
                 Console.WriteLine($"{disco.Name} {libreGB:F1} Libres de {totalGB:F1} ");
           

                double porcentaje = libreGB / totalGB * 100;
                if (porcentaje < 15)
                {
                    Console.WriteLine($"[!] POCO ESPACIO disponible - {porcentaje:F0}%");
                }
                else
                {
                    Console.WriteLine($"OK disponible - {porcentaje:F0}%");
                }
            }

        }
    }
}