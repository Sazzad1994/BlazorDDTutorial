using BlazorDD.Components.Pages;

namespace BlazorDD.Models
{
    public static class ServerRepository
    {
        private static List<ServerEntity>servers=new List<ServerEntity>()
        {
            new ServerEntity{ServerId=1,ServerName="A",LocatedCity="dhk"},
            new ServerEntity{ServerId=2,ServerName="B",LocatedCity="dhk"},
            new ServerEntity{ServerId=3,ServerName="C",LocatedCity="dhk"},
            new ServerEntity{ServerId=4,ServerName="D",LocatedCity="dhk"},
            new ServerEntity{ServerId=5,ServerName="E",LocatedCity="ctg"},
            new ServerEntity{ServerId=6,ServerName="F",LocatedCity="ctg"},
            new ServerEntity{ServerId=7,ServerName="G",LocatedCity="ctg"},
            new ServerEntity{ServerId=8,ServerName="H",LocatedCity="ctg"},
            new ServerEntity{ServerId=9,ServerName="I",LocatedCity="raj9"},
            new ServerEntity{ServerId=10,ServerName="J",LocatedCity="raj10"},
            new ServerEntity{ServerId=11,ServerName="K",LocatedCity="raj11"},
            new ServerEntity{ServerId=12,ServerName="L",LocatedCity="raj12"},
            new ServerEntity{ServerId=13,ServerName="M",LocatedCity="syl13"},
            new ServerEntity{ServerId=14,ServerName="N",LocatedCity="syl14"},
            new ServerEntity{ServerId=15,ServerName="O",LocatedCity="syl15"},
        };

        public static void AddServer(ServerEntity entity)
        {
           var maxId= servers.Max(s=>s.ServerId);
            entity.ServerId = maxId+1;
            servers.Add(entity);
        }

        public static List<ServerEntity> GerServer() => servers;
        public static void RemoveServer(ServerEntity entity) { servers.Remove(  entity); }
        public static List<ServerEntity> GetServerByCity(string city)
        {
          return  servers.Where(s => s.LocatedCity.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static ServerEntity? GetServerById(int id)
        {
            var server = servers.FirstOrDefault(s => s.ServerId == id);
            if (server != null)
            {
                return new ServerEntity
                {
                    ServerId = server.ServerId,
                    ServerName = server.ServerName,
                    LocatedCity = server.LocatedCity,
                    IsOnline = server.IsOnline
                };
            }

            return null;
        }

        public static void UpdateServer(int serverId, ServerEntity entity)
        {
            if (serverId != entity.ServerId) return;

            var serverToUpdate = servers.FirstOrDefault(s => s.ServerId == serverId);
            if (serverToUpdate != null)
            {
                serverToUpdate.IsOnline = entity.IsOnline;
                serverToUpdate.ServerName = entity.ServerName;
                serverToUpdate.LocatedCity = entity.LocatedCity;
            }
        }

        public static void DeleteServer(int serverId)
        {
            var server = servers.FirstOrDefault(s => s.ServerId == serverId);
            if (server != null)
            {
                servers.Remove(server);
            }
        }

        public static List<ServerEntity>SerachServer(string ServerFilter)
        {
          return  servers.Where(s=>s.ServerName.Contains(ServerFilter,StringComparison.OrdinalIgnoreCase)).ToList();
        }

       




    }
}
