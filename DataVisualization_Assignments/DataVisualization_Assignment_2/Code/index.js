
function updateChart(selectedYear, sortOrder) {
  d3.csv("population.csv").then(function(data) {
    // Filter the data to include only the selected year
    var filteredData = data.filter(function(d) {
      return d.Year === selectedYear;
    });
    
    
    // Sort the filtered data based on the selected sort order
    if (sortOrder === "asc") {
      filteredData.sort(function(a, b) {
        return a.Population - b.Population;
      });
    } else if (sortOrder === "desc") {
      filteredData.sort(function(a, b) {
        return b.Population - a.Population;
      });
    }
    
    // Remove the existing SVG element
    d3.select("#chart svg").remove();
  
    // Your chart updating code here, using the filteredData
    // ...
    // Define custom colors for each bar
    var colorScale = d3.scaleOrdinal()
    .domain(["Male", "Female"])
    .range(["#394867", "#BA0F30", ]);
    
    //Initialize data
    var chartData = [
      {name: "Male", color: "#394867"},
      {name: "Female", color: "#BA0F30"},
     ];
   
   
    // Set the dimensions and margins of the chart
    var margin = {top: 40, right: 30, bottom: 80, left: 200},
        width = 1500 - margin.left - margin.right,
        height = 600 - margin.top - margin.bottom;
   
    // Create the SVG element and append it to the placeholder
    var svg = d3.select("#chart")
      .append("svg")
      .attr("class", "barChart")
      .attr("width", width + margin.left + margin.right)
      .attr("height", height + margin.top + margin.bottom + 20)
      .append("g")
      .attr("transform", "translate(" + (margin.left - 50) + "," + (margin.top + 15) + ")");
   
    // Set the x and y scales
    var xScale = d3.scaleLinear()
    .domain([0, 800000000])//100000000
    .range([0, 1200]);
   
    var yScale = d3.scaleBand()
    .domain(filteredData.map(function(d) { return d.Country; }))
    .range([0, height])
    .padding(0.5);
   
   
    // Create the x-axis
    svg.append("g")
      .attr("transform", "translate(0," + height + ")")
      .call(d3.axisBottom(xScale).ticks(10))
      .selectAll("text")
      .attr("y", 15)
      .attr("dy", ".5em")
      .attr("font-weight", "600")
      .style("font-size", "13.5px")
      .style("text-anchor", "middle");
   
      svg.append("text")
      .attr("transform",
            "translate(" + (width/2) + " ," +
                           (height + margin.top + 25) + ")")
      .style("text-anchor", "middle")
      .style("font-size", "24px")
      .attr("font-weight", "600")
      .text("Population");
   
    // Create the y-axis
    svg.append("g")
      .call(d3.axisLeft(yScale)
        .tickPadding(5)
        .ticks(10)
      )
      .attr("font-weight", "600")
      .style("font-size", "13px");
      
      svg.append("text")
      .attr("transform", "rotate(-90)")
      .attr("y", 45 - margin.left)
      .attr("x", 0 - (height / 2))
      .attr("dy", "1em")
      .attr("font-weight", "600")
      .style("text-anchor", "middle")
      .style("font-size", "24px")
      .text("Country");
   
  // Create the bars
    var bars = svg.selectAll(".bar")
    .data(filteredData)
    .enter()
    .append("g")
    .attr("class", "bar")
    .attr("transform", function(d) { return "translate(0," + yScale(d.Country) + ")"; });
   
    bars.append("rect")
    .attr("x", 0)
    .attr("y", function(d, i) { return (i % 2) * 25; })
    .attr("width", function(d) { return xScale(d.Population); })
    .attr("height", 20)
    .attr("fill", function(d) {
      if (d.Gender === "Male") return colorScale("Male");
      else if (d.Gender === "Female") return colorScale("Female");
    })
    .on("mouseover", function(d) {
      d3.select(this).attr("opacity", 1); // Highlight the bar
      d3.select(this).attr('class', 'highlight');
    
     var rect = this.getBoundingClientRect(); // Get position of bar relative to viewport
     var tooltipHeight = tooltip.node().getBoundingClientRect().height; // Get height of tooltip
    
    tooltip.html("<b>" + d.Country + "\'s " + d.Gender + " " + "Population: </b>" + d.Population + "<br>" + "<b>" +
                 d.Country + "\'s Kids Population: </b>" + d.Kids + "<br>" + "<b>" + d.Country + "\'s Adult Population: </b>"
                 + d.Adult + "<br>" + "<b>" + d.Country + "\'s Elderly Population: </b>" + d.Elderly + "<br>" + "<b>" +
                 "Percentage of Unemployment: </b>" + d.Unemployment)
       .style("visibility", "visible") // Show the tooltip
       .style("top", (rect.top + rect.height / 2 - tooltipHeight / 2 - 5) + "px") // Position the tooltip in the center of the bar
       .style("left", (rect.left + rect.width + 5) + "px"); // Position the tooltip to the right of the bar
     })
     .on("mouseout", function(d) {
      d3.select(this).attr("opacity", 1); // Unhighlight the bar
      d3.select(this).attr('class', 'bar');
      tooltip.style("visibility", "hidden"); // Hide the tooltip
  });

  var tooltip = d3.select("body")
                  .append("div")
                  .attr("class", "tooltip")
                  .style("position", "absolute")
                  .style("z-index", "10")
                  .style("visibility", "hidden");
    
  var legend = svg.selectAll(".legend")
                  .data(chartData)
                  .enter()
                  .append("g")
                  .attr("class", "legend")
                  .attr("transform", function(d, i) { return "translate(" + ((i + 4) * 100) + ", -40)"; });
  
  legend.append("rect")
        .attr("x", 600)
        .attr("width", 18)
        .attr("height", 18)
        .style("fill", function(d) { return d.color; });
        
  legend.append("text")
        .attr("x", 630)
        .attr("y", 10)
        .attr("dy", ".35em")
        .style("font-size", "15px")
        .text(function(d) { return d.name; });
  });
}

updateChart("2013");