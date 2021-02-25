namespace ativ_07._12.classes
{
    public class PessoaJuridica : pessoa //ultiliza a herança
    {
        public string cnpj;

        public string inscriçãoEstadual;

        public bool ValidarCNPJ(string documento){
            if(documento !=  ""){
                return true;
            }

            return false;
        }
    }
}