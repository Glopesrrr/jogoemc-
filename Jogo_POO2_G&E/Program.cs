using System;
using System.Collections;

public class JogoPooII
{
    static int pontosplayer1 = 0;
    static int pontosplayer2 = 0;
    static int gols1 = 0;
    static int gols2 = 0;
    static int cartas1 = 0;
    static int cartas2 = 0;
    static int cartas3 = 0;
    static int player1amarelo = 0;
    static int player2amarelo = 0;
    static int pontosdarodada = 0;



    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o nick do jogador 1: ");
        string player1 = Console.ReadLine();

        Console.WriteLine("Digite o nick do jogador 2: ");
        string player2 = Console.ReadLine();

        int energia1 = 10;
        int energia2 = 10;

        // Sorteio de quem começa o jogo
        Random objRand = new Random();
        int playervez = objRand.Next(1, 3);
        int proximoplayer = playervez;

        if (playervez == 1)
        {
            Console.WriteLine("Player 1 iniciando o jogo...");
        }
        else
        {
            Console.WriteLine("Player 2 iniciando o jogo...");
        }


        while (energia1 > 0 || energia2 > 0)
        {
            Console.WriteLine("Pressione ENTER para sortear as cartas!");
            string start = Console.ReadLine();

            // Sorteio das cartas
            Random objCarta1 = new Random();
            int sorteio1 = objCarta1.Next(1, 7);

            Random objCarta2 = new Random();
            int sorteio2 = objCarta2.Next(1, 7);

            Random objCarta3 = new Random();
            int sorteio3 = objCarta3.Next(1, 7);


            string nomecarta1 = "";

            switch (sorteio1)
            {
                case 1:
                    nomecarta1 = "Energia";
                    cartas1 = 3;
                    break;
                case 2:
                    nomecarta1 = "Falta";
                    cartas1 = 2;
                    break;
                case 3:
                    nomecarta1 = "Cartão Vermelho";
                    cartas1 = 1;
                    break;
                case 4:
                    nomecarta1 = "Cartão Amarelo";
                    cartas1 = 1;
                    break;
                case 5:
                    nomecarta1 = "Penalti";
                    cartas1 = 0;
                    break;
                case 6:
                    nomecarta1 = "Gol";
                    cartas1 = 2;
                    break;
            }

            string nomecarta2 = "";

            switch (sorteio2)
            {
                case 1:
                    nomecarta2 = "Energia";
                    cartas2 = 3;
                    break;
                case 2:
                    nomecarta2 = "Falta";
                    cartas2 = 2;
                    break;
                case 3:
                    nomecarta2 = "Cartão Vermelho";
                    cartas2 = 1;
                    break;
                case 4:
                    nomecarta2 = "Cartão Amarelo";
                    cartas2 = 1;
                    break;
                case 5:
                    nomecarta2 = "Penalti";
                    cartas2 = 0;
                    break;
                case 6:
                    nomecarta2 = "Gol";
                    cartas2 = 2;
                    break;
            }

            string nomecarta3 = "";

            switch (sorteio3)
            {
                case 1:
                    nomecarta3 = "Energia";
                    cartas3 = 3;
                    break;
                case 2:
                    nomecarta3 = "Falta";
                    cartas3 = 2;
                    break;
                case 3:
                    nomecarta3 = "Cartão Vermelho";
                    cartas3 = 1;
                    break;
                case 4:
                    nomecarta3 = "Cartão Amarelo";
                    cartas3 = 1;
                    break;
                case 5:
                    nomecarta3 = "Penalti";
                    cartas3 = 0;
                    break;
                case 6:
                    nomecarta3 = "Gol";
                    cartas3 = 2;
                    break;
            }

            string sorteado1 = sorteio1.ToString();
            string sorteado2 = sorteio2.ToString();
            string sorteado3 = sorteio3.ToString();

            Console.WriteLine(nomecarta1 + " -- " + nomecarta2 + " -- " + nomecarta3);
            Console.WriteLine("================= === =================");

            // Alternar player 
            if (playervez == 1)
            {
                proximoplayer = 2;
            }
            else
            {
                proximoplayer = 1;
            }


            // Checagem das cartas 
            if ((sorteio1 != sorteio2 && sorteio1 != sorteio3) || (sorteio2 != sorteio1 && sorteio2 != sorteio3) || (sorteio3 != sorteio1 && sorteio3 != sorteio2))
            {
                pontosdarodada = cartas1 + cartas2 + cartas3;
                Console.WriteLine("RODADA PLAYER: " + proximoplayer);
                Console.WriteLine("PONTOS: " + pontosdarodada);
                if (playervez == 1)
                {
                    energia1 = energia1 - 1;
                    pontosplayer1 += pontosdarodada;
                    proximoplayer = 2;
                }
                else
                {
                    energia2 = energia2 - 1;
                    pontosplayer2 += pontosdarodada;
                    proximoplayer = 1;
                }
            }

            if (nomecarta1 == "ENERGIA" && nomecarta2 == "ENERGIA" && nomecarta3 == "ENERGIA")
            {
                Console.WriteLine("VOCÊ GANHOU 1 ENERGIA...!");
                if (playervez == 1)
                {
                    energia1++;
                }
                else
                {
                    energia2++;
                }
            }

            if (nomecarta1 == "GOL" && nomecarta2 == "GOL" && nomecarta3 == "GOL")
            {
                Console.WriteLine("O PLAYER " + playervez + " CRAVOU 1 GOL E GANHOU 1 PONTO!!!");

                if (playervez == 1)
                {
                    pontosplayer1++;
                    energia1 = energia1 - 1;
                    gols1 += 1;
                }
                else
                {
                    pontosplayer2++;
                    energia2 = energia2 - 1;
                    gols2 += 1;
                }
            }

            if (nomecarta1 == "PENALTI" && nomecarta2 == "PENALTI" && nomecarta3 == "PENALTI")
            {
                Console.WriteLine("POSIÇÃO PARA BATER O PENALTI: ESQUERDA[E], DIREITA[D], CENTRO[C]");
                string penalti = Console.ReadLine();

                Console.WriteLine("POSIÇÃO PARA DEFENDER O PENALTI: ESQUERDA[E], DIREITA[D], CENTRO[C]");
                string defesa = Console.ReadLine();

                if (penalti != defesa)
                {
                    Console.WriteLine("GOOOOOOLLLLL!!!!!");
                    if (playervez == 1)
                    {
                        gols1 += 1;
                    }
                    else
                    {
                        gols2 += 1;
                    }
                }
                else
                {
                    Console.WriteLine("DEFESA!!!");
                }
                if (playervez == 1)
                {
                    pontosplayer1++;
                    energia1 = energia1 - 1;
                }
                else
                {
                    pontosplayer2++;
                    energia2 = energia2 - 1;
                }
            }

            if (nomecarta1 == "FALTA" && nomecarta2 == "FALTA" && nomecarta3 == "FALTA")
            {
                Console.WriteLine("PASSE A VEZ!");
                if (playervez == 1)
                {
                    energia1 = energia1 - 1;
                }
                else
                {
                    energia2 = energia2 - 1;
                }
            }

            if (nomecarta1 == "CARTÃO AMARELO" && nomecarta2 == "CARTÃO AMARELO" && nomecarta3 == "CARTÃO AMARELO")
            {
                if (playervez == 1)
                {
                    energia1 = energia1 - 1;
                }
                else
                {
                    energia2 = energia2 - 1;
                }
                Console.WriteLine("O PLAYER " + playervez + " PERDEU 1 ENERGIA..");

                if ((playervez == 1 && player1amarelo == 1) || (playervez == 2 && player2amarelo == 1))
                {
                    Console.WriteLine("O PLAYER " + playervez + " PERDEU 2 ENERGIAS..");
                    if (playervez == 1)
                    {
                        energia1 -= 2;
                        player1amarelo += 1;
                    }
                    else
                    {
                        energia2 -= 2;
                        player2amarelo += 1;
                    }
                }
                else
                {
                    Console.WriteLine("PRÓXIMO CARTÃO AMARELO O PLAYER PERDERÁ 2 ENERGIAS...!!");
                    if (playervez == 1)
                    {
                        energia1 -= 1;
                        player1amarelo = 1;
                    }
                    else
                    {
                        energia2 -= 1;
                        player2amarelo = 1;
                    }
                }
            }

            if (nomecarta1 == "CARTÃO VERMELHO" && nomecarta2 == "CARTÃO VERMELHO" && nomecarta3 == "CARTÃO VERMELHO")
            {
                Console.WriteLine("O PLAYER " + playervez + " PERDEU 2 ENERGIAS..");

                if (playervez == 1)
                {
                    energia1 -= 2;
                }
                else
                {
                    energia2 -= 2;
                }
            }



            playervez = proximoplayer;
            Console.WriteLine("------       ------");
            Console.WriteLine("       -----       ");
            Console.WriteLine("ENERGIAS JOGADOR 1: " + energia1);
            Console.WriteLine("ENERGIAS JOGADOR 2: " + energia2);
            Console.WriteLine("------ ----- ------");
            Console.WriteLine("       -----       ");
            Console.WriteLine("GOLS JOGADOR 1: " + gols1);
            Console.WriteLine("GOLS JOGADOR 2: " + gols2);
            Console.WriteLine("------ ----- ------");
            Console.WriteLine("       -----       ");
            Console.WriteLine("PONTOS JOGADOR 1: " + pontosplayer1);
            Console.WriteLine("PONTOS JOGADOR 2: " + pontosplayer2);
            Console.WriteLine("================= === =================");
        }


        if (energia1 <= 0 && energia2 <= 0)
        {
            Console.WriteLine("                         ");
            Console.WriteLine(">>>>>>>>>> FIM DE JOGO <<<<<<<<<<");
            Console.WriteLine("                         ");


            if (gols1 == gols2 && pontosplayer1 == pontosplayer2)
            {
                Console.WriteLine("A PARTIDA EMPATOU");
                Console.WriteLine("JOGADOR 1: " + " PONTUAÇÃO: " + pontosplayer1 + " / " + "GOLS: " + gols1);
                Console.WriteLine("JOGADOR 2: " + " PONTUAÇÃO: " + pontosplayer2 + " / " + "GOLS: " + gols2);
                Console.WriteLine("                         ");
            }
            else if (gols1 == gols2)
            {
                if (pontosplayer1 > pontosplayer2)
                {
                    Console.WriteLine("JOGADOR 1 VENCE O JOGO!");
                    Console.WriteLine("JOGADOR 1: " + " PONTUAÇÃO: " + pontosplayer1 + " / " + "GOLS: " + gols1);
                    Console.WriteLine("JOGADOR 2: " + " PONTUAÇÃO: " + pontosplayer2 + " / " + "GOLS: " + gols2);
                    Console.WriteLine("                         ");
                }
                else
                {
                    Console.WriteLine("JOGADOR 2 VENCE O JOGO!");
                    Console.WriteLine("JOGADOR 1: " + " PONTUAÇÃO: " + pontosplayer1 + " / " + "GOLS: " + gols1);
                    Console.WriteLine("JOGADOR 2: " + " PONTUAÇÃO: " + pontosplayer2 + " / " + "GOLS: " + gols2);
                    Console.WriteLine("                         ");
                }
            }
            else if (gols1 > gols2)
            {
                Console.WriteLine("JOGADOR 1 VENCE O JOGO!");
                Console.WriteLine("JOGADOR 1: " + " PONTUAÇÃO: " + pontosplayer1 + " - " + "GOLS: " + gols1);
                Console.WriteLine("JOGADOR 2: " + " PONTUAÇÃO: " + pontosplayer2 + " / " + "GOLS: " + gols2);
                Console.WriteLine("                         ");
            }
            else
            {
                Console.WriteLine("JOGADOR 2 VENCE O JOGO!");
                Console.WriteLine("JOGADOR 1: " + " PONTUAÇÃO: " + pontosplayer1 + " / " + "GOLS: " + gols1);
                Console.WriteLine("JOGADOR 2: " + " PONTUAÇÃO: " + pontosplayer2 + " / " + "GOLS: " + gols2);
                Console.WriteLine("                         ");
            }

            Console.WriteLine("DIGITE '-1' PARA SAIR, OU DIGITE '0' PARA UMA NOVA PARTIDA.");
            string opcao = Console.ReadLine();

            if (opcao == "-1")
            {
                // Encerrando o programa
                Console.WriteLine("OTIMO JOGO...");
                Console.WriteLine("FOI UMA HONRA JOGADOR!");
                Environment.Exit(0);
            }
            else if (opcao == "0")
            {
                // Reiniciando o programa
                Main(args);
            }
            else
            {
                Console.WriteLine("OPÇÃO INCORRETA");
                Console.WriteLine("CONTINUANDO O JOGO...!");
            }
        }
    }
}
//TRABALHO PRODUZIDO POR GABRIEL LOPES E ERIK LEAL - 4º SEMESTRE POO2 
