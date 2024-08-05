using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutoServices _produtoServices;

        public ProdutosController(ProdutoServices produtoServices)
        {
            _produtoServices = produtoServices;
              
        }


        [HttpGet]
        public async Task<List<Produto>> GetProdutos()
            => await _produtoServices.GetAsync();



        [HttpPost]
        public async Task<Produto> PostProduto(Produto produto)
        {
            await _produtoServices.CreatAsync(produto);
            return produto;
        }

        [HttpPut]
        public async Task<Produto> UpdateProduto(string id, Produto produto)
        {
            await _produtoServices.UpdateAsync(id, produto);
            return produto;
        }

    }
}
