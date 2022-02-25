using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Alura.WebAPI.Api.Filtros
{
    public class TagDescriptionsDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags = new[] {
                new Tag { Name = "Livros", Description = "Consulta e mantém os livros." },
                new Tag { Name = "Listas", Description = "Consulta listas de leitura."}
            };
        }

    }
}
