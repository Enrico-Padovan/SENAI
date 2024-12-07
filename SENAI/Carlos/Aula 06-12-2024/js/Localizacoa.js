//capturar os elementos do formulário
const formulario = document.querySelector("#formulario");

//vamos escutar os eventos do html com o método addEventListener()

formulario.addEventListener('submit', function(e){
    e.preventDefault(); //muda o comportamento padrão do formulário
    const inputPeso = e.target.querySelector('#peso'); //pegando peso
    const inputAltura = e.target.querySelector('#altura'); //pegando altura

    const peso = Number(inputPeso.value); //coverte o valor digitado para número
    const altura = Number(inputAltura.value); //converte o valor digitado para número

    const imc = calcularImc(peso, altura)

    const classificacao = tabelaImc(imc);

    mostrarResultado(classificacao)
});

function calcularImc(peso, altura){
    let imc = peso / (altura ** 2);
    let Imc = imc.toFixed(2);
    return imc.toFixed(2);
}

function tabelaImc(imc){
    const classificacao = ['Abaixo do Peso', 'Peso Ideal', 'Levemente Acima do Peso', 'Obsidade Grau I', 'Obsidade Grau II (Severa)', 'Obsidade Grau III (Mórbida)', ]
    if(imc >= 39.9) return classificacao[5];
    if(imc >= 34.9) return classificacao[4];
    if(imc >= 29.9) return classificacao[3];
    if(imc >= 24.9) return classificacao[2];
    if(imc >= 18.5) return classificacao[1];
    if(imc < 18.5) return classificacao[0];


}

function mostrarResultado(msg){
    const resultado = document.querySelector("#resultado");
    resultado.innerHTML = msg;
}