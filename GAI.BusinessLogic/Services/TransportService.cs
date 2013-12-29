using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using GAI.BusinessLogic.DataModel;

namespace GAI.BusinessLogic.Services
{
    public class TransportService
    {
        public Dictionary<string, Transport> GetTransports()
        {
            using (var entities = new GAIEntities())
            {
                var dictionary = entities.Transports
                    .Include(Includes.EntityIncludes.PoliceDeparrtment)
                    .Include(Includes.EntityIncludes.Owner)
                                    .ToDictionary(tr => tr.License_Plates);
                return dictionary;
            }
        }

        public void SaveOrUpdateTransport(Transport transport, out Exception exception)
        {
            if (string.IsNullOrEmpty(transport.License_Plates))
            {
                exception = new NullReferenceException();
                return;
            }
            using (var entity = new GAIEntities())
            {
                if (transport.Id == 0)
                {
                    var existingTransport =
                        entity.Transports.FirstOrDefault(tr => tr.License_Plates == transport.License_Plates);
                    if (existingTransport != null)
                    {
                        exception = new DataException();
                        return;
                    }

                    entity.Transports.Add(transport);
                    exception = null;
                }
                else
                {
                    var existingTransport = entity.Transports.FirstOrDefault(tr => tr.Id == transport.Id);
                    entity.Entry(existingTransport).CurrentValues.SetValues(transport);
                    
                    exception = null;
                }

                entity.SaveChanges();
            }
        }

    }
}
