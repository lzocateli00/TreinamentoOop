namespace OOP
{

    /// <summary>
    /// Encapsular é esconder a implementação, o criador do encapsulamento quer 
    /// expressar ao consumidor do metodo, que o mesmo não precisa saber como
    /// o metodo funciona.
    /// 
    /// </summary>
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa("Padrao", 110);
            espresso.Ligar();
            espresso.FazerCafe();
            espresso.Desligar();
        }
    }
}