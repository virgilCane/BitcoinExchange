import {Chart} from "chart.js";
import * as $ from "jquery";
export class BtcChart{
  
  async attached(){
    var canvas = <HTMLCanvasElement>document.getElementById('btc-chart');
    var ctx = canvas.getContext('2d');
    var lineChart = new Chart(ctx,{
      type: 'line',
      data:{
        datasets: [{
          label: 'Prices',
          data: [{
                  x:10,
                  y:20
                 },
                 {
                  x:15,
                  y:15
                 },
                 {
                  x:20,
                  y:25
                 },
                 {
                  x:25,
                  y:22
                 },
                 {
                  x:30,
                  y:5
                 },
                 {
                  x:32,
                  y:27
                 },
                 {
                  x:35,
                  y:30
                 }
                ]
        }],
        labels:["1",'2','3','4','5','6','7','8','9','10']
      },
      options: {
        elements: {
          line: {
              tension: 0
          }
      },
      scales:{
        xAxes: [{
          ticks:{
            beginAtZero: true, 
            min: -15
          }
        }],
        yAxes:[{
          ticks:{
            beginAtZero:true,
            min:-15
          }
        }]
      }
      }
    });
    
    console.log(lineChart.data.datasets[0].data);
  }

}
