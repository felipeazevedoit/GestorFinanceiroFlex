using GestaoFinanceiroFlex.Dominio.Interfaces;
using GestorFinanceiroFlex.Repositorio.Data;
using GestorFinanceiroFlex.Repositorio.Interfaces;
using GestorFinanceiroFlex.Repositorio;
using GestorFinanceiroFlex.Servicos.Interfaces;
using GestorFinanceiroFlex.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Injeção de Dependência das Interfaces
builder.Services.AddSingleton<ICalculadoraCobranca, CalculadoraCobrancaServico>();
builder.Services.AddSingleton<ICalculadoraComissao, CalculadoraComissaoServico>();
builder.Services.AddSingleton<IIntegracaoModulos, IntegracaoModulosServico>();
builder.Services.AddSingleton<IBoletoRepositorio, BoletoRepositorio>();
builder.Services.AddSingleton<IContextoMemoria, ContextoMemoria>();
builder.Services.AddSingleton<ICrmRepositorio, CrmRepositorio>();
builder.Services.AddSingleton<IFaturaRepositorio, FaturaRepositorio>();
builder.Services.AddSingleton<IVendaRepositorio, VendaRepositorio>();
builder.Services.AddSingleton<IGeradorBoleto, GeradorBoletoServico>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();