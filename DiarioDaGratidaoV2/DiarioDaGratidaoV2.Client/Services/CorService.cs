using DiarioDaGratidaoV2.Shared.Entidades;
using DiarioDaGratidaoV2.Shared.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;


namespace DiarioDaGratidaoV2.Client.Services;

public class CorService : ICorRepository
{
    private readonly HttpClient httpClient;

    private readonly JsonSerializerOptions _options;

    public CorService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
    public async Task<Cor> AddCorAsync(Cor model)
    {
        var cor = await httpClient.PostAsJsonAsync("api/cor/Add-cor", model);
        var response = await cor.Content.ReadFromJsonAsync<Cor>();
        return response!;
    }

    public async Task<Cor> DeleteCorAsync(int corId)
    {
        var cor = await httpClient.DeleteAsync($"api/cor/Delete-cor/{corId}");
        var response = await cor.Content.ReadFromJsonAsync<Cor>();
        return response!;
    }

    public async Task<List<Cor>> GetAllCoresAsync()
    {
        var cors = await httpClient.GetAsync("api/cor/cors");
        var response = await cors.Content.ReadFromJsonAsync<List<Cor>>();
        return response!;
    }

    public async Task<Cor> GetCorAsync(int corId)
    {
        var cor = await httpClient.GetAsync($"api/cor/cor/{corId}");
        var response = await cor.Content.ReadFromJsonAsync<Cor>();
        return response!;
    }

    public async Task<Cor> UpdateCorAsync(Cor model)
    {
        var cor = await httpClient.PutAsJsonAsync("api/cor/Update-cor", model);
        var response = await cor.Content.ReadFromJsonAsync<Cor>();
        return response!;
    }
}