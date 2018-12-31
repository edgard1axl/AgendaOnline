// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var botaoEmail = document.querySelector("#adicionar-email");
botaoEmail.addEventListener("click", function (event) {
    event.preventDefault();

    var tabela = document.querySelector("#tabela-email"); 
    tabela.appendChild(montarEmailTr());

    var botaoRemover = document.querySelectorAll(".btnRemoverEmail");
    botaoRemover.forEach(function (botao) {
        botao.addEventListener("click", function (e) {
            var alvo = e.target.parentNode;
            alvo.parentNode.remove();
        });
    });
    
});

var botaoTelefone = document.querySelector("#adicionar-telefone");
botaoTelefone.addEventListener("click", function (event) {
    event.preventDefault();

    var tabela = document.querySelector("#tabela-telefone");
    tabela.appendChild(montarTelefoneTr());

    var botaoRemover = document.querySelectorAll(".btnRemoverTelefone");
    botaoRemover.forEach(function (botao) {
        botao.addEventListener("click", function (e) {
            var alvo = e.target.parentNode;
            alvo.parentNode.remove();
        });
    });

});


function montarEmailTr() {        
    var tipo = document.querySelector("#tipo_email").selectedOptions[0].text;
    var tabelaTr = document.createElement("tr");
    tabelaTr.className = "email-dado";

    var email = document.querySelector("#email").value;

    var valido = validaEmail(email, tipo);

    if (valido == false)
        return;

    var tabelaTdEmail = document.createElement("td");
    tabelaTdEmail.textContent = email;
    tabelaTdEmail.className = "info-email";

    var tabelaTdTipoEmail = document.createElement("td");
    tabelaTdTipoEmail.textContent = tipo;
    tabelaTdTipoEmail.className = "info-email-tipo";

    var tabelaTdRemover = document.createElement("td");
    var btnRemover = document.createElement("button");
    
    btnRemover.textContent = "remover";
    btnRemover.value = "remover";
    btnRemover.type = "button";
    btnRemover.className = "btnRemoverEmail";
    tabelaTdRemover.appendChild(btnRemover);

    tabelaTr.appendChild(tabelaTdEmail);
    tabelaTr.appendChild(tabelaTdTipoEmail);
    tabelaTr.appendChild(tabelaTdRemover);

    return tabelaTr;
}

function montarTelefoneTr() {    
    var tipo = document.querySelector("#tipo_telefone").selectedOptions[0].text;
    var tabelaTr = document.createElement("tr");
    tabelaTr.className = "telefone-dado";

    var telefone = document.querySelector("#telefone").value;

    var valido = validaTelefone(telefone, tipo);

    if (valido == false)
        return;

    var tabelaTdTelefone = document.createElement("td");
    tabelaTdTelefone.textContent = telefone;

    var tabelaTdTipoTelefone = document.createElement("td");
    tabelaTdTipoTelefone.textContent = tipo;

    var tabelaTdRemover = document.createElement("td");
    var btnRemover = document.createElement("button");

    btnRemover.textContent = "remover";
    btnRemover.value = "remover";
    btnRemover.type = "button";
    btnRemover.className = "btnRemoverTelefone";
    tabelaTdRemover.appendChild(btnRemover);

    tabelaTr.appendChild(tabelaTdTelefone);
    tabelaTr.appendChild(tabelaTdTipoTelefone);
    tabelaTr.appendChild(tabelaTdRemover);

    return tabelaTr;
}

function validaEmail(dado, tipoEmail) {
    var valido = true;
    var emails = document.querySelectorAll(".email-dado");

    emails.forEach(function (item) {
        var email = item.querySelector(".info-email");
        var tipo = item.querySelector(".info-email-tipo");

        if (email.textContent == dado && tipo.textContent == tipoEmail) {
            valido = false;            
        }

    });

    return valido;
}

function validaTelefone(dado, tipoTelefone) {
    var valido = true;
    var telefones = document.querySelectorAll(".telefone-dado");

    telefones.forEach(function (item) {
        var telefone = item.querySelector(".info-telefone");
        var tipo = item.querySelector(".info-telefone-tipo");

        if (telefone.textContent == dado && tipo.textContent == tipoTelefone) {
            valido = false;
        }

    });

    return valido;
}
