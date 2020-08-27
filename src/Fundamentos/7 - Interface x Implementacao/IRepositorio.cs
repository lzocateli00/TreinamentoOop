namespace OOP
{
    /// <summary>
    /// Os principios do SOLID recomendam em todos os casos:
    /// Programe para uma interface e não para uma implementação.
    /// 
    /// Uma implementação gera acoplamento, o que dificulta a manutenção e a 
    /// testabilidade do codigo.
    /// </summary>
    public interface IRepositorio
    {
        void Adicionar(object entidade);
    }
}