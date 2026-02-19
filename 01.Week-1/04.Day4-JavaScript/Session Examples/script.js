function calculate() {

  // Read values from DOM
  let x = Number(document.getElementById("num1").value );
  let y = Number( document.getElementById("num2").value );
  let operator = document.getElementById("operator").value;

  let z;

  // Switch Case
  switch (operator) {
    case "+":
      z = x + y;
      break;

    case "-":
      z = x - y;
      break;

    case "*":
      z = x * y;
      break;

    case "/":
      z =   x / y ;
      break;

    default:
      z = "Invalid Operation";
  }

  // Display Result
  document.getElementById("result").innerText =
    "Output  : " + z;
}
