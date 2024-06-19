class hero{
    constructor(nickname, level, type){
        this.nickname = nickname
        this.level = level
        this.type = type
    }
    typeAtaque(){
        ataque = 
    }
    attack(){
        if(this.type === "mago"){
            console.log(`O ${this.type} Atacou usando MAGIA`)
        }
        else if(this.type === "guerreiro"){
            console.log(`O ${this.type} Atacou usando Espada`)
        }
        else if(this.type === "monge"){
            console.log(`O ${this.type} atacou usando Artes Marciais`)
        }
        else if(this.type === "ninja"){
            console.log(`O ${this.type} atacou usando Shuriken`)
        }
        else{
            console.log("Opção invalida")
        }
    }
}


