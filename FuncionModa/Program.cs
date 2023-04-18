class program
{
    /*
    La siguiente función calcula la moda estadística, el valor mínimo y máximo de un arreglo de cualquier tamaño, solo con estructuras de datos de tipo arreglo.
    Utiliza dos arreglos: El que recibe como parámetro y uno local que contendrá las frecuencias de cada elemento del arreglo de entrada en la posición análoga.
    Por ejemplo: La frecuencia del elemento entrada[3] se encontrará en frecuencias[3]
    La moda será el número que se encuentre en la misma posición que la máxima frecuencia del arreglo []frecuencias en el arreglo de entrada.
    Si el arreglo tiene varias modas, retornará la primera que encuentre de ellas.
    El algoritmo funciona siempre que el arreglo de entrada tenga al menos un elemento.
    */
    public static void modaMaxMin(double[] entrada)
{
    int[] frecuencias = new int[entrada.Length];
    double moda = 0;
    double maximaFrecuencia = 0;
        //Antes de ordenar el arreglo de entrada, imprimimos los valores del mismo:
        Console.Write("Los elementos ingresados son: [");
        for (int i = 0; i < entrada.Length; i++)
        {
            Console.Write(entrada[i]);
            Console.Write(",");
        }
        Console.Write("]");
        //Ordenamos el arreglo de entrada
        Array.Sort(entrada);
    

    //Cálculo de la moda.
    for (int i = 0; i < entrada.Length; i++)
    {
            //Esta variable es local al bucle para que sea inicializada en cero con cada iteración del mismo.
            int f = 0;
            for(int j = 0; j<entrada.Length; j++)
            {
                //Cada vez que este valor sea encontrado repetido, su frecuencia será almacenada en el contador f.
                if (entrada[i] == entrada[j])
                {
                    f++;
                }
            }
            //Almacenamos la frecuencia de este valor en su respectiva posición análoga.
            frecuencias[i] = f;
            //El valor de la moda será la del número que tendrá, en el arreglo []entrada la misma posición del mayor de los valores de f almacenados en el arreglo []frecuencias.
            //Este algoritmo considerará la primera moda que encuentre si el arreglo tiene varias modas.
            if (f > maximaFrecuencia)
            {
                moda = entrada[i];
                maximaFrecuencia = f;
            }
            
    }
    

        //Cálculo del máximo y el mínimo e impresión de los resultados por consola
        //Como el arreglo se encuentra ordenado, sus valores máximo y mínimo serán el primer y último valor que contenga respectivamente.
    Console.WriteLine($"\nEl valor de la moda es: {moda}\nEl valor máximo es: {entrada[entrada.Length-1]}\nEl valor mínimo es: {entrada[0]}");
}
    static void Main(string[] args)
    {
        double[] arregloprueba = new double[] { 1, 1, 1, 1.5, 2, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 800, 0.00001 };
        double[] arregloprueba2 = new double[] {1};
        double[] arregloprueba3 = new double[] {0,0,0,-20,-200,1,2200,2020,1,5,5,0};
        double[] arregloprueba4 = new double[] {100,100,10,10,10,10,1,1,1,-5,-5,-5,-5,-5,-555};
        modaMaxMin(arregloprueba);
        modaMaxMin(arregloprueba2);
        modaMaxMin(arregloprueba3);
        modaMaxMin(arregloprueba4);
    }
}