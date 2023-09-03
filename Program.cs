using System;

namespace Applicati{

    class Program{
        static void Main(string[] args){                        

            Console.WriteLine("Pirámide Normal: P");
            Console.WriteLine("Pirámide Invertida: IP");

            Console.WriteLine("¿Qué desea realizar? ");
            string op = Console.ReadLine();

            int val = 0;

            if(op == "P" || op == "p"){
                val = 1;
            }else if(op == "IP" || op == "ip"){
                val = 2;
            }else if(op == "IP" || op == "ip"){
                val = 3;
            }

            switch(val){
                case 1: 
                        normalPyr();
                break;

                case 2:
                        InvPyr();
                break;

                case 3:
                    Console.WriteLine("Opción inválida");                    
                return;
            }
        }


        static void normalPyr(){
            Console.WriteLine("Digite el ancho del árbol: ");
                        int ancho = int.Parse(Console.ReadLine());  //Leemos el valor

                        int anchoCopy = ancho;  //Creamos una copia del ancho p poder modificarla

                        int mod = ancho % 2;    //Verificamos si el ancho es par o impar

                        if(mod == 0){ // Si el ancho es un número par

                            numPar(ancho, anchoCopy);
                                
                        }else{  //Si el ancho es número impar
                            numImpar(ancho, anchoCopy);
                        }
        }

        static void numPar(int ancho, int anchoCopy){
            int mul;

                for(int i = 0; i < ancho; i++){ //Iniciamos el bucle para crear cada fila
                
                    mul = 2 * i;     //Variable que nos ayudará a rellenar la pirámide          

                    if(mul > ancho){    //No queremos que el ancho de la piramide sea mayor al establecido
                        break;          //Finaliza el ciclo
                    }      
                                 
                    showPir(anchoCopy, mul, i-1);   //Funcion que crea la piramide por fila 

                    anchoCopy--;        //Restamos 1 a la copia
                }
        }



        static void numImpar(int ancho, int anchoCopy){
            int mul;

                for(int i = 1; i < ancho; i++){
                
                    mul = (2 * i) - 1;

                    if(mul > ancho){
                        break;
                    }      
                                 
                    showPir(anchoCopy, mul, i-1);

                    anchoCopy--;
                }
        }


        static void InvPyr(){
            Console.WriteLine("Ingresa la altura de la piramide invertida:");
            int altura = int.Parse(Console.ReadLine());
            
            int n = altura;

            for(int i = 1; i <= altura; i++){
                
                n += (n- 1);
                
                if(i > 1){
                    for(int j = 0; j < i - 1; j++){
                        Console.Write(" ");
                    }
                }
                
                for(int j = 0; j < n; j++){
                    Console.Write("*");
                }
                
                Console.WriteLine("");
                n = altura - i;
            }
        }


        static void showPir(int ancho, int mul, int cont){
            
            if(mul > 2){    //Nos ayuda a acomodar el árbol
                ancho -= cont;
            }
            for(int i = 1; i < ancho; i++){ //Bucle para crear una fila de espacios de acuerdo al ancho
                
                Console.Write(" ");

            }
            Console.Write("*"); //Se imprime un asterisco

            if(mul != 0){   //Se rellena la fila en caso de ser necesario

                for(int i = 1; i < mul; i++) {
                
                    Console.Write(" *");
                }
                            
            }            

            Console.Write(" ");
            Console.WriteLine("");

        }
    }
}

