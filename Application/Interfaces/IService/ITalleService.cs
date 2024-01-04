using Application.Request;
using Application.Response;

namespace Application.Interfaces.IService
{
    public interface ITalleService
    {
        TalleResponse GetTalleById(int talleId);
        List<TalleResponse> GetTalleList();
        TalleResponse CreateTalle(TalleRequest request);
        TalleResponse RemoveTalle(int talleId);
        TalleResponse UpdateTalle(int talleId, ColorRequest request);
    }
}
