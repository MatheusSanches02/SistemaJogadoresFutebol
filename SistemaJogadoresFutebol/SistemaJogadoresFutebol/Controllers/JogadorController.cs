using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaJogadoresFutebol.Models;

namespace SistemaJogadoresFutebol.Controllers
{
    public class JogadorController : Controller
    {
        //Lista estática para armazenar carros
        private static List<Jogador> _jogadores = new List<Jogador>();
        //Contador estático para definir o código do veiculo
        private static int _id = 0;
        private void CarregarLigas()
        {
            var ligas = new List<string>(new string[] { "Brasileirão", "Ligue 1", "Premiere League", "Serie A", "La Liga", "Bundesliga" });

            ViewBag.LigaDisputada = new SelectList(ligas);
        }

        // GET: JogadorController
        public ActionResult Index()
        {
            return View(_jogadores);
        }

        // GET: JogadorController/Cadastrar
        public ActionResult Cadastrar()
        {
            CarregarLigas();
            return View();
        }

        // POST: JogadorController/Cadastrar
        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            jogador.Id = ++_id;
            _jogadores.Add(jogador);
            TempData["mensagemSucesso"] = "Jogador Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        // GET: JogadorController/Editar/id
        public ActionResult Editar(int id)
        {
            var jogador = _jogadores.Find(x => x.Id == id);
            CarregarLigas();
            return View(jogador);
        }

        // POST: JogadorController/Edit/id
        [HttpPost]
        public ActionResult Editar(Jogador jogador)
        {
            _jogadores[_jogadores.FindIndex(x => x.Id == jogador.Id)] = jogador;
            TempData["mensagemSucessoEditar"] = "Jogador editado com sucesso!";
            return RedirectToAction("Index");
        }

        // POST: JogadorController/Deletar/id
        [HttpPost]
        public ActionResult Deletar(int id)
        {
            var index = _jogadores.FindIndex(x => x.Id == id);
            _jogadores.RemoveAt(index);
            TempData["mensagemSucessoExcluir"] = "Jogador excluido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
