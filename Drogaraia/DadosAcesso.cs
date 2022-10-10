public class Dadocliente

{
    public string email;
    public string senha;
   
    private DadosCliente dadocliente;

    //metodos
    public Dadocliente()
    {
        this.email = "";
        this.senha = "";
        this.dadocliente = new DadosCliente();
    }
            public Dadocliente(string par_nome, string par_email, string par_cpf, string par_telefone,
                                string par_senha, string par_datanas)
             
            {

                this.dadocliente.nome = par_nome;
                this.email = par_email;
                this.dadocliente.cpf = par_cpf;
                this.dadocliente.telefone = par_telefone;
                this.senha = par_senha;
                this.dadocliente.datanas = par_datanas;

            }
    // metódos - get/set

    public string getnome()
    {
        return this.dadocliente.nome;
    }

    public void setnome(string p_nome)
    {
        this.dadocliente.nome = p_nome;
    }
    public string getcpf()
    {
        return this.dadocliente.cpf;
    }

    public void setcpf(string p_cpf)
    {
        this.dadocliente.cpf = p_cpf;
    }
    public string gettelefone()
    {
        return this.dadocliente.telefone;
    }

    public void settelefone(string p_telefone)
    {
        this.dadocliente.telefone = p_telefone;
    }
    public string getdatanas()
    {
        return this.dadocliente.datanas;
    }

    public void setdatanas(string p_datanas)
    {
        this.dadocliente.datanas = p_datanas;
    }
    public string getemail()
    {
        return this.email;
    }

    public void setemail(string p_email)
    {
        this.email = p_email;
    }
    public string getsenha()
    {
        return this.senha;
    }

    public void setsenha(string p_senha)
    {
        this.senha = p_senha;
    }

}
    



