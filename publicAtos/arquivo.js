
// alert('Helo World');

// var numero = 1;

// if (numero == "1") { //compara os valores/conteúdes.
//   alert('True');
// } else {
//   alert('False');
// }

// if (numero === "1") { //compara o tipo e o valor. Ambos devem ser iguais.
//   alert('True');
// } else {
//   alert('False');
// }


//*************************************************

// var suco = 2;

// switch (suco) {
//   case 1:
//     alert('fazer 1 compo de suco');
//     break;
//   case 2:
//     alert('dazer meia jarra de suco');
//     break;
//   case 3:
//     alert('fazer uma jarra de suco');
//     break;
//   default:
//     alert('opcao default');
// }

//********************************************

// var alunos = ["Douglas", "Rodrigo", "Thiago", "Pablo", "Francisco"];

// for (var i = 0; i < alunos.length; i++) {
//   alert(alunos[i]);
// }

//************************************************ */

// var texto = "";
// var numero = 1;

// while (numero < 10) {
//   texto += numero + " ";
//   numero++;
// }

// alert(texto);

//*************************************************** */
//var

// for (let i = 0; i <= 10; i++) {
//   if (i % 2 == 0) {
//     //console.log(i);
//     alert(i);
//   }

// }

//***************************************************** */

// var total = 0;
// for (let i = 0; i <= 100; i++) {
//   total += i;
// }
// alert(total);

//********************************************** */

// function mostrarpares() {
//   for (let i = 0; i <= 10; i++) {
//     if (i % 2 == 0) {
//       console.log(i);
//       alert(i);
//     }
//   }
// }

// function mostrarsomatorio() {
//   var total = 0;
//   for (let i = 0; i <= 100; i++) {
//     total += i;
//   }
//   alert(total);
//   console.log(total);
// }

// function deixarcaixaalta() {
//   var x = document.getElementById("nome");
//   x.value = x.value.toUpperCase();
// }

// function mostrarnomeidade() {
//   var nome = document.getElementById("nome").value;
//   var idade = document.getElementById("idade").value;
//   alert(nome + " tem " + idade + " anos.");
// }

// function maiorDeIdade() {
//   var nome = document.getElementById("nomeMaiorIdade").value;
//   var idade = document.getElementById("idadeMaiorIdade").value;

//   if (idade >= 18) {
//     alert(nome + " maior de idade!");
//   } else {
//     alert(nome + " menor de idade!");
//   }
// }

// function somar() {
//   var n1 = parseInt(document.getElementById("n1").value);
//   var n2 = parseInt(document.getElementById("n2").value);

//   var soma = n1 + n2;

//   console.log(soma);
//   alert(soma);
// }

// function somarMudarCorBotao() {
//   var n1 = parseInt(document.getElementById("valor1").value);
//   var n2 = parseInt(document.getElementById("valor2").value);

//   var soma = n1 + n2;

//   if (soma % 2 == 0) {
//     var botao = document.getElementById("btn");
//     botao.style.backgroundColor = " blue";
//   } else {
//     document.getElementById("btn").style.background = "green";
//     //botao.style.backgroundColor = " green";
//   }


// }

// **************************************************************************   Aula 08/11/2021

function mudarCor(cor) {
  document.body.style.backgroundColor = cor;
}

function esconderTexto() {
  var par = document.getElementById("paragrafo");

  if (par.style.display == "none") {
    par.style.display = "block";
  } else {
    par.style.display = "none";
  }
}

function removerTexto() {
  var par = document.getElementById("paragrafo");

  if (par.style.visibility == "hidden") {
    par.style.visibility = "visible";
  } else {
    par.style.visibility = "hidden";
  }

  //  some o elemento:
}

function verificaChecks() {
  var cboxes = document.getElementsByName("animal");
  var contagem = 0;

  for (let i = 0; i < cboxes.length; i++) {
    if (cboxes[i].checked == true) {
      contagem++;
    }

    if (contagem >= 2) {
      document.getElementById("btnHabilitar").removeAttribute("disabled");
    } else {
      document.getElementById("btnHabilitar").setAttribute("disabled", "disabled");
    }

  }

}

function checkTodos(todos) {
  var cboxes = document.getElementsByClassName("animalTodos");

  for (let i = 0; i < cboxes.length; i++) {
    cboxes[i].checked = todos.checked;
  }
  verificaChecks();
}

function fonte(cor) {
  document.getElementById("paragrafoCor").style.color = cor;
}

function fundo(cor) {
  document.getElementById("paragrafoCor").style.backgroundColor = cor;
}

var tamanho = 16;

function tamanhoMais() {
  tamanho++;
  document.getElementById("paragrafoCor").style.fontSize = tamanho + "px";
}
function tamanhoMenos() {
  tamanho--;
  document.getElementById("paragrafoCor").style.fontSize = tamanho + "px";
}

function maiusculo() {
  var txtOriginal = document.getElementById("paragrafoCor");
  txtOriginal.innerText = txtOriginal.innerText.toUpperCase();
}

function minusculo() {
  document.getElementById("paragrafoCor").innerHTML =
    document.getElementById("paragrafoCor").innerHTML.toLocaleLowerCase();
}

function validar() {
  var nome = document.getElementById("nome").value;
  var senha1 = document.getElementById("senha1").value;
  var senha2 = document.getElementById("senha2").value;

  if (nome != "" && senha1 != "" && senha2 != "") {
    if (senha1 == senha2) {
      if (senha1.length > 5 && senha1.length < 11) {
        alert("Salvo com sucesso!");
      } else {
        alert("A senha precisa ter mínimo de 5 caracteres!");
      }
    } else {
      alert("Senhas precisam ser iguais!");
    }
  } else {
    alert("Favor preencher os campos!");
  }

}

function alteraVisibilidade(tipop) {
  if (tipop == "fisica") {
    document.getElementById("pessoaFisica").style.display = "block";
    document.getElementById("pessoaJuridica").style.display = "none";
  } else {
    document.getElementById("pessoaFisica").style.display = "none";
    document.getElementById("pessoaJuridica").style.display = "block";
  }
}

function mascara(m, t, e) {
  var cursor = t.selectionStart;
  var texto = t.value;
  texto = texto.replace(/\D/g, '');
  var l = texto.length;
  var lm = m.length;
  if (window.event) {
    id = e.keyCode;
  } else if (e.which) {
    id = e.which;
  }
  cursorfixo = false;
  if (cursor < l) cursorfixo = true;
  var livre = false;
  if (id == 16 || id == 19 || (id >= 33 && id <= 40)) livre = true;
  ii = 0;
  mm = 0;
  if (!livre) {
    if (id != 8) {
      t.value = "";
      j = 0;
      for (i = 0; i < lm; i++) {
        if (m.substr(i, 1) == "#") {
          t.value += texto.substr(j, 1);
          j++;
        } else if (m.substr(i, 1) != "#") {
          t.value += m.substr(i, 1);
        }
        if (id != 8 && !cursorfixo) cursor++;
        if ((j) == l + 1) break;
      }
    }
  }
  if (cursorfixo && !livre) cursor--;
  t.setSelectionRange(cursor, cursor);
}


// **************************************************************************   Aula 09/11/2021