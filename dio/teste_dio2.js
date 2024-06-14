function ranked(win, lose){
    let myRanked = win - lose
    if (myRanked <= 10){
        console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de Ferro")
    }else if ((myRanked > 10)&&(myRanked <= 20)){
        console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de bronze")
    }else if((myRanked > 20)&&(myRanked <= 30)){
      console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de prata")
    }else if((myRanked > 30)&&(myRanked <= 80)){
      console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de ouro")
    }else if((myRanked > 80)&&(myRanked <= 90)){
      console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de platina")
    }else if((myRanked > 90)&&(myRanked <= 100)){
      console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de imortal")
    }else if(myRanked > 100){
      console.log("O Herói tem de saldo de"+" "+myRanked+" "+"está no nível de radiante")
    }else{
      console.log("fez caquinha, tente novamente.")
    }
  }
  ranked(555, 5)

  
  
  