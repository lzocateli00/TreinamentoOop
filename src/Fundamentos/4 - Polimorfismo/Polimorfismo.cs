namespace OOP
{
    /// <summary>
    /// Poli = multiplo / morfus = formas
    /// Quando há herança eixste um forte acoplamento e baixa coesao
    /// Quando a super classe muda, a classe concreta quebra !!! 
    /// </summary>
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            :base(nome, voltagem)
        {
            
        }


        private static void AquecerAgua()
        {
            
        }

        private static void MoerGraos()
        {
            
        }

        public override void Desligar()
        {

        }

        public void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        public override void Ligar()
        {


        }

        /// <summary>
        /// Polimorfismo
        /// </summary>
        //public override void Ligar()
        //{
        //    // Verificar recipiente de agua
        //}

        ///// <summary>
        ///// Polimorfismo
        ///// </summary>
        //public override void Desligar()
        //{
        //    // Resfriar aquecedor
        //}
    }
}