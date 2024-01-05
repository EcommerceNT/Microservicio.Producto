using Application.Interfaces.ICommand;
using Application.Interfaces.IQuerys;
using Application.Interfaces.IService;
using Application.Request;
using Application.Response;
using Domain.Entities;

namespace Application.UseCase.TallesService
{
    public class TalleService : ITalleService
    {
        private readonly ITalleCommand _command;
        private readonly ITalleQuery _query;

        public TalleService(ITalleCommand command, ITalleQuery query)
        {
            _command = command;
            _query = query;
        }

        public TalleResponse GetTalleById(int talleId)
        {
            var talle = _query.GetTalleById(talleId);

            if (talle == null)
            {
                throw new ArgumentException($"No se encontró el talle con el identificador {talleId}.");
            }

            return MappingTalle(talle);
        }

        public List<TalleResponse> GetTalleList()
        {
            var talleList = _query.GetTalleList();

            List<TalleResponse> talleResponseList = new List<TalleResponse>();

            foreach (var talle in talleList)
            {
                talleResponseList.Add(MappingTalle(talle));
            }

            return talleResponseList;
        }

        public TalleResponse CreateTalle(TalleRequest request)
        {
            var talle = new Talle
            {
                Descripcion = request.Descripcion,
            };

            _command.InsertTalle(talle);

            return MappingTalle(talle);
        }

        public TalleResponse RemoveTalle(int talleId)
        {
            if (_query.GetTalleById(talleId) == null)
            {
                throw new ArgumentException($"No se encontró el talle que desea eliminar con el identificador '{talleId}'.");
            }

            var talle = _command.RemoveTalle(talleId);

            return MappingTalle(talle);
        }

        public TalleResponse UpdateTalle(int talleId, TalleRequest request)
        {
            var talle = _query.GetTalleById(talleId);

            if (talle == null)
            {
                throw new ArgumentException($"No se encontró el talle con el identificador {talleId}.");
            }

            talle.Descripcion = request.Descripcion;

            _command.UpdateTalle(talle);

            return MappingTalle(talle);
        }

        private static TalleResponse MappingTalle(Talle talle)
        {
            return new TalleResponse
            {
                Id = talle.TalleId,
                Descripcion = talle.Descripcion,
            };
        }
        public bool ExisteTalle(string talle)
        {
            return _query.ExisteTalle(talle);
        }
    }
}
