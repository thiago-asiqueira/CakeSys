using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.CakeSys.Domain.Tests.Fakes;

namespace TS.CakeSys.Domain.Tests
{
    [TestClass]
    public sealed class UsuarioTest
    {
        private int _id;
        private string _nome;
        private string _login;
        private string _senha;
        private PerfilTipo _perfil;
        private Status _status;

        private UsuarioEntity _usuario;

        [TestInitialize]
        public void Initialize()
        {
            var _usuarioFake = UsuarioFake.MakeSingle();
            _id = _usuarioFake.Id;
            _nome = _usuarioFake.Nome;
            _login = _usuarioFake.Login;
            _senha = _usuarioFake.Senha;
            _perfil = _usuarioFake.Perfil;
            _status = _usuarioFake.Status;
        }

        public void CriarUsuario()
        {
            _usuario = new UsuarioEntity(_id,_nome,_login,_senha,_perfil,_status);
        }

        [TestMethod]
        public void QuandoEuCriarUmUsuario()
        {
            //arrange

            //act
            CriarUsuario();

            //assert
            Assert.IsNotNull(_usuario);
            Assert.AreEqual(_id,_usuario.Id);
            Assert.AreEqual(_nome, _usuario.Nome);
            Assert.AreEqual(_login, _usuario.Login);
            Assert.AreEqual(_senha, _usuario.Senha);
            Assert.AreEqual(_perfil,_usuario.Perfil);
            Assert.AreEqual(_status, _usuario.Status);
        }



    }

    public enum PerfilTipo
    {
        Usuario = 1,
        Administrador = 2
    }

    public enum Status
    {
        Ativo = 1,
        Inativo = 0
    }

    public sealed class UsuarioEntity
    {

        public UsuarioEntity(int id, string nome, string login, string senha, PerfilTipo perfil, Status status)
        {
            Id = id;
            Nome = nome;
            Login = login;
            Perfil = perfil;
            Status = status;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public PerfilTipo Perfil { get; set; }
        public Status Status { get; set; }
    }
}
