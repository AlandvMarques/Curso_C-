/*



Console.WriteLine("Primeiro Hello, World!");


// Aprendendo diferente tipos de dados:

int idade = 33;
Console.WriteLine(idade);

string nome = "Alan kevinho";
Console.WriteLine(nome);

decimal valor = 200.99m;
Console.WriteLine(valor);

double valorDoble = 200.99;
Console.WriteLine(valorDoble);

float valorFloat = 200.99f;
Console.WriteLine(valorFloat);

char flag = 'Y';
Console.WriteLine(flag);

bool ativo = true;
Console.WriteLine(ativo);

var idadeNova= 34;
Console.WriteLine(idadeNova);


// Aprendo Cosnt: 
const string descricao = "Curso c#";
Console.WriteLine(descricao);


// Aprendedo Operadores ritméticos:

int numero1 = 2;
var numero2 = 2;


int soma = numero1 + numero2;
Console.WriteLine(soma);

int subitracao = numero1 - numero2;
Console.WriteLine(subitracao);

int multiplicacao = numero1 * numero2;
Console.WriteLine(multiplicacao);


int multiplicacao2 = (numero1 * numero2) * 10;
Console.WriteLine(multiplicacao2);


int divicao= numero1 / numero2;
Console.WriteLine(divicao);

int divicao2= (numero1 / numero2) * 2;
Console.WriteLine(divicao2);


// Aprendendo Operadores Relacionais:

var numeroOperado1 = 2;
var numeroOperado2 = 4;

bool igual = numeroOperado1 == numeroOperado2;
Console.WriteLine (igual);

bool maior = numeroOperado1 > numeroOperado2;
Console.WriteLine (maior);

bool menor = numeroOperado1 < numeroOperado2;
Console.WriteLine (menor);

bool maiorOuIgual = numeroOperado1 >= numeroOperado2;
Console.WriteLine (maiorOuIgual);

bool menorOuIgual = numeroOperado1 <= numeroOperado2;
Console.WriteLine (menorOuIgual);

bool diferente = numeroOperado1 != numeroOperado2;
Console.WriteLine (diferente);


// Operadores Lógicos:

var numeroLogico1 = 2;
var numeroLogico2 = 4;

bool valido = numeroLogico2 > numeroLogico1 && 6 > 7;
Console.WriteLine(valido);
//false

bool valido2 = numeroLogico2 > numeroLogico1 || 6 > 7;
Console.WriteLine(valido2);
//false

bool valido3 = !(numeroLogico2 > numeroLogico1);
Console.WriteLine(valido3);


// Operadores Ternários:

bool ativoTernario = true;
string status = ativoTernario == false ? "Cadastro ativo" : "Cadastro inativo";
Console.WriteLine(status);

*/















/*

// Criando a Primeira Função: 

// Exemplo 1: 
var nome1 = nomeCompleto();

Console.WriteLine(nome1);

string nomeCompleto(){

    return "Alan Kevin";
};

// Exemplo 2:
var nome2 = nomeCompleto2 ();

Console.WriteLine(nome2);

string nomeCompleto2 (){
    string primeiroNome = "Alan";
    string segundoNome = "Marques";

    return primeiroNome + " " + segundoNome;
};

//Exemplo 3:
var soma = somaValores();

Console.WriteLine(soma);

int somaValores(){
    return 8 + 2;
};


//Utilizamos o void quando não precisamos retornar valor na função;
// Exemplo 4:

EscreverTodosResultados ();

void EscreverTodosResultados(){
    var n1 = testen1 ();
    var n2 = testen2();

    Console.WriteLine(n1);
    Console.WriteLine(n2);
};


int testen1 (){
    int primeiroN1= 10;
    int segundoN2= 8;
    
    return primeiroN1 + segundoN2;
};

string testen2 (){
    var primeiroN1= 10;
    var segundoN2= 8;
    
    return primeiroN1 + " " + segundoN2;
};

*/



//Criando Função que recebe parâmetros:

//Exemplo 1:
var soma = somaValores (3 ,5);

Console.WriteLine (soma);

int somaValores(int a, int b){
    return a + b;
};

//Exemplo 2:

var nome = nomeEIndade("Alan", 20);

Console.WriteLine(nome);

string nomeEIndade(string nome, int idade ){
    return "Meu nome é " + nome + " e tnho "+ idade;
};