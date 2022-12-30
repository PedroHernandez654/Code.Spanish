const btnAbrirModal = document.querySelector("#btn-abrir-listaMensajes");
const btnCerrarModal = document.querySelector("#btn-cerrar-listaMensajes");
const modal = document.querySelector("#listaMensajes");
var m = [];
var mensaje = 'MENSAJE DESDE PRM20';
let cont=0;
let cont2=0;
/*Guardamos todo en checks que tenga clase Ganador*/
var checks_Ganador = document.querySelectorAll(".Ganador");
/*Guardamos todo en checks que tenga clase Mensaje*/
var checks_Mensaje = document.querySelectorAll(".Mensaje");
btnAbrirModal.addEventListener("click", ()=>{
    listaMensajes.showModal();
})

btnCerrarModal.addEventListener("click",()=>{
    Recorrido();
    //Algo();
    modal.close();
})


function Checked(){
    var msg=0;
    var gnr=0;
    /*Recorremos todo lo que tenga la clase Ganador*/
    checks_Ganador.forEach((e)=>{
        if(e.checked == true){
            gnr++;
        }
    })

    var msg=0;
    var msgs=0;
    /*Recorremos todo lo que tenga la clase Mensaje*/
    checks_Mensaje.forEach((e)=>{
        if(e.checked == true){
            msg++;
        }
        msgs++;
    })

    console.log('Ganadores Seleccionados: ' + gnr)
    console.log('Mensajes Seleccionados: ' + msg);
    console.log('Mensajes en Total: ' + msgs);

    /* Validaciones */
    
    if(gnr % 3 == 0){
        Se_Msgs = gnr/3;/*Si es Par se hace la división entre 3 para saber el número de mensajes a enviar */
        console.log("********************No Residuo**********************");
        console.log("Mensajes Seleccionados Después: " + Se_Msgs);
        /*Selección de mensajes*/
        for(var i=0; i<Se_Msgs;i++){
            if(checks_Mensaje[i].checked==false){
                checks_Mensaje[i].checked=true;
            }
        }

        /*Mensajes Enviados */
        checks_Mensaje.forEach((e)=>{
            if(e.checked == true){
                console.log(e);
            }
        })
    }else{
        if(gnr<=3){
            console.log("********************Residuo**********************");
            console.log('Mensajes Seleccionados Después: ' + msg);
            checks_Mensaje.forEach((e)=>{
                if(e.checked == true){
                    console.log(e);
                }
            })
        }else{/*Si es Impar se hace la división entre 3 para saber el número de mensajes a enviar y se le suma 1 */
            msg++;
            console.log("********************Residuo**********************");
            console.log('Mensajes Seleccionados Después: ' + msg);
            for(var i=0; i<msg;i++){
                if(checks_Mensaje[i].checked==false){
                    checks_Mensaje[i].checked=true;
                }
            }
            /*Mensajes Enviados*/
            checks_Mensaje.forEach((e)=>{
                if(e.checked == true){
                    console.log(e);
                }
            })
        }
    }
}

function Envio(){
    var m = [];
    function Mensaje(){
        this.id = 0
        this.mensaje = ""
        this.estatus = false
    }

    //Recorrido e inserción de los mensajes con estatus
    for(var i=0; i<checks_Mensaje.length;i++){
        const mensajess = new Mensaje()
        if(checks_Mensaje[i].checked==true){
            mensajess.id = i+1;
            mensajess.mensaje = checks_Mensaje[i].value;
            mensajess.estatus = true;
            m.push(mensajess);
        }else{
            mensajess.id = i+1;
            mensajess.mensaje = checks_Mensaje[i].value;
            mensajess.estatus = false;
            m.push(mensajess);
        }
    }

    //Método para encontrar el id
    function findStatus(item){
        /*for(let l=1;l<=m.length;l++){
            ID++;
        }*/
        return item.estatus == true && item.id == 1;
    }

//Encontrar el ID que tenga estatus verdadero
    function FindAlgo(index){
        for(let i=0;i<m.length;i++){
            if(m[i].estatus == true){
                index=m[i].id;
                return index;
            }
        }
    }
    //Envio SMS
    function EnviarSMS(Ganador, Mensaje){
        console.log("Enviando SMS a: " + Ganador);
        console.log("SMS enviado: " + Mensaje);
    }


    const S = m.find(findStatus);
    const IDFI = FindAlgo();
    //Envío de mensaje a los ganadores
    for(let j=0;j<checks_Ganador.length;j++){
        if(checks_Ganador[j].checked==true){
            EnviarSMS(checks_Ganador[j].name,m[IDFI-1].mensaje);
           /*if((j+1)>m.length){
                EnviarSMS(checks_Ganador[j].name,m[j-m.length].mensaje);
            }else{
                if((j+1)==m.length){
                    EnviarSMS(checks_Ganador[j].name,m[j].mensaje);
                }
            }*/
        }
   }
   console.log(S);

/*

/*
    let contM=0;
    let gnr=0;
    const ArrayM = [];
    const ArrayMS = [];
    const ArrayGndr = [];
    const ArrayGndrs = [];

    //Recorrido de mensajes en total y seleccionados
    checks_Mensaje.forEach((e)=>{
        if(e.checked == true){
            contM++;
            ArrayMS.push(e);
        }
        ArrayM.push(e);
    })
    //Recorrido de ganadores en total
    checks_Ganador.forEach((e)=>{
        if(e.checked == true){
            gnr++;
            ArrayGndrs.push(e);
        }
        ArrayGndr.push(e);
    })

    console.log("Ganadores Seleccionados:");
    console.log(gnr);
    console.log(ArrayGndrs);
    console.log("Ganadores:");
    console.log(ArrayGndr);
    console.log("Mensajes Seleccionados:");
    console.log(contM);
    console.log(ArrayMS);
    console.log("Mensajes En Total:");
    console.log(ArrayM);




    /*for(let j=0;j<checks_Ganador.length;j++){
        console.log(j);
    }*/
    /*for(let j=0; j<=checks_Ganador.length;j++){
        for(let i=0; i<=checks_Mensaje.length;i++){
            if(i==j){
                console.log("*****************IGUAL*********************");
                console.log("Mensaje: " + i + " | " + "Ganadores: " + j);
            }
            if(j>i){
                console.log("");
                console.log("****************NOIGUAL*******************");
                console.log("Mensaje: " + i + " | " + "Ganadores: " + j);
                i=0;
            }
        }
    }
    for(let i=0; i<=checks_Mensaje.length;i++){
        if(i==checks_Mensaje.length){
            i=0;
            console.log('**********************');
            cont++;
        }
        if(cont == 3){
            break;
        }
        console.log(i+1);
    }*/
}

function Recorrido(){
    //Clase del Mensaje con sus atributos
    function Mensaje(){
        this.id = 0
        this.mensaje = ""
        this.estatus = false
        this.used = false
    }
    //Recorrido e inserción de los mensajes con estatus
    if(m == ""){
        //Se insertan una vez
        for(var i=0; i<checks_Mensaje.length;i++){
            const mensajess = new Mensaje();
            if(checks_Mensaje[i].checked==true){
                //Atrubutos a insertar
                cont++;
                mensajess.id = i;
                mensajess.mensaje = checks_Mensaje[i].name;
                mensajess.estatus = true;
                //Inserción
                m.push(mensajess);
            }else{
                mensajess.id = i;
                mensajess.mensaje = checks_Mensaje[i].name;
                mensajess.estatus = false;
                m.push(mensajess);
            }
            
        }
    }else{
        //En caso de no estar vacío el Array unicamente se actualizan
        for(var i=0; i<checks_Mensaje.length;i++){//Se recorren y de acuerdo si están seleccionados se actualiza
            if(checks_Mensaje[i].checked == true){
                if(m[i].estatus == false){
                    cont++;
                    m[i].estatus = true;
                }
            }else if(checks_Mensaje[i].checked == false){
                if(m[i].estatus == true){
                    cont--;
                    m[i].estatus = false;
                }
            }
        }
    }
    console.log(m);
    console.log(cont);
}

function Algo(){
    var cont=0;
    for(var i=0;i<m.length;i++){
        if(m[i].estatus == false){
            cont++;
            if(cont == m.length){
                console.log("Seleccione al menos 1");
            }
        }
    }
}

function Env(){
//Envio SMS
    function EnviarSMS(Ganador, Mensaje, id){
        console.log("Enviando SMS a: " + Ganador);
        console.log("SMS enviado: " + Mensaje);
        console.log("ID: " + id);

    }
    //Encontrar el ID que tenga estatus verdadero
    function FindMsg(index){
        for(let i=0;i<m.length;i++){
            if(m[i].estatus == true && m[i].used == false){
                index=m[i].id;
                return index;
            }
            if((i+1)==m.length){
                for(let l=0;l<m.length;l++){
                    m[l].used = false;
                }
                return FindMsg();
            }
        }
    }

    //Envío de mensaje a los ganadores
    for(let j=0;j<checks_Ganador.length;j++){
        if(cont >= 1){
            const IDFI = FindMsg();
            if(checks_Ganador[j].checked==true){
                cont2++;
                if(cont2>2 && cont <= 1){
                    return alert("Si desea enviar más de " + (cont2-1) + " mensajes. Favor de seleccionar más mensajes");
                }else{
                    EnviarSMS(checks_Ganador[j].name,m[IDFI].mensaje,m[IDFI].id);
                    m[IDFI].used = true;
                    //Deshabilitar y deseleccionar
                    checks_Ganador[j].disabled = true;
                    checks_Ganador[j].checked = false;
                }                
            }
        }else{
            return alert("Seleccione 1");
        }
   }
   cont2=0;

   console.log(m);

}