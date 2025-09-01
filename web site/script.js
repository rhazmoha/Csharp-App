
let promise = new Promise((resolve, reject) => {
    let isOk = true;

    setTimeout(() => {
        if(isOk){
            resolve("ok");
        }else {
            reject("error");
        }
    }, 5000);

});

async function getData(){
    try {
        let response  = await promise;

    console.log(response);
    }catch(error){
        console.log("this is an " + error);
    }
}


async function test(){
    throw new Error("err dans promise");
}

test().then(res => console.log(res)).catch(err => console.log(err.message));

console.log("end of program");