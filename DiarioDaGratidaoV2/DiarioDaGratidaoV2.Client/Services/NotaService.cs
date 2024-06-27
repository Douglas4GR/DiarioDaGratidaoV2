using DiarioDaGratidaoV2.Shared.Entidades;
using DiarioDaGratidaoV2.Shared.Interfaces;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;


namespace DiarioDaGratidaoV2.Client.Services;

public class NotaService : INotaRepository
{
    private readonly HttpClient httpClient;

    private readonly JsonSerializerOptions _options;

    public NotaService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }
    public async Task<Nota> AddNotaAsync(Nota model)
    {
        var nota = await httpClient.PostAsJsonAsync("api/nota/Add-nota", model);
        var response = await nota.Content.ReadFromJsonAsync<Nota>();
        return response!;
    }

    public async Task<Nota> DeleteNotaAsync(int notaId)
    {
        var nota = await httpClient.DeleteAsync($"api/nota/Delete-nota/{notaId}");
        var response = await nota.Content.ReadFromJsonAsync<Nota>();
        return response!;
    }

    public async Task<List<Nota>> GetAllNotasAsync()
    {
        var notas = await httpClient.GetAsync("api/nota/notas");
        var response = await notas.Content.ReadFromJsonAsync<List<Nota>>();
        return response!;
    }

    public async Task<Nota> GetNotaAsync(int notaId)
    {
        var nota = await httpClient.GetAsync($"api/nota/nota/{notaId}");
        var response = await nota.Content.ReadFromJsonAsync<Nota>();
        return response!;
    }

    public async Task<Nota> UpdateNotaAsync(Nota model)
    {
        var nota = await httpClient.PutAsJsonAsync("api/nota/Update-nota", model);
        var response = await nota.Content.ReadFromJsonAsync<Nota>();
        return response!;
    }
}