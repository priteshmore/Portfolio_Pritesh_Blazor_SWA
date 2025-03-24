function createParentChildBubbles(svgId, skills) {
    const svg = d3.select(`#${svgId}`);

    if (svg.empty()) {
        console.error(`SVG with ID '${svgId}' not found.`);
        return;
    }

    const container = svg.node().parentElement;
    const width = container.clientWidth;
    const height = 500;

    svg.attr("viewBox", `0 0 ${width} ${height}`)
        .attr("preserveAspectRatio", "xMidYMid meet");

    const nodesMap = new Map(skills.map(skill => [skill.id, skill]));

    const links = skills
        .filter(d => d.parent && nodesMap.has(d.parent))
        .map(d => ({
            source: nodesMap.get(d.parent),
            target: d
        }));

    // Group isolation: Adding a grouping factor to separate different groups
    const groupMap = {};
    skills.forEach(skill => {
        if (!groupMap[skill.group]) {
            groupMap[skill.group] = { x: Math.random() * width, y: Math.random() * height };
        }
    });

    const simulation = d3.forceSimulation(skills)
        .force("center", d3.forceCenter(width / 2, height / 2))
        .force("charge", d3.forceManyBody().strength(-100))
        .force("collision", d3.forceCollide().radius(d => d.size + 20).strength(1.2))
        .force("link", d3.forceLink(links)
            .id(d => d.id)
            .distance(100)
            .strength(0.7)
        )
        .force("grouping", d3.forceManyBody().strength(-200)) // Increase group repulsion
        .force("x", d3.forceX(d => groupMap[d.group].x).strength(0.2))
        .force("y", d3.forceY(d => groupMap[d.group].y).strength(0.2));

    const randomColor = () => `hsl(${Math.random() * 360}, 70%, 60%)`;

    const link = svg.selectAll("line")
        .data(links)
        .enter()
        .append("line")
        .attr("stroke", "#ccc")
        .attr("stroke-width", 1.5);

    const node = svg.selectAll("circle")
        .data(skills)
        .enter()
        .append("circle")
        .attr("r", d => d.size)
        .attr("fill", randomColor)
        .attr("stroke", "#333")
        .attr("stroke-width", 1.5)
        .style("cursor", "pointer")
        .on("mouseover", (event, d) => {
            simulation.force("collision").strength(1.5).radius(d.size + 25);
            simulation.alpha(0.5).restart();
        })
        .on("mouseout", () => {
            simulation.force("collision").strength(1.2).radius(d => d.size + 20);
            simulation.alpha(0.2).restart();
        });

    const labels = svg.selectAll("text")
        .data(skills)
        .enter()
        .append("text")
        .attr("text-anchor", "middle")
        .attr("dy", ".35em")
        .attr("fill", "#fff")
        .attr("font-size", d => (d.parent ? "12px" : "14px"))
        .style("pointer-events", "none")
        .text(d => d.id);

    simulation.on("tick", () => {
        link
            .attr("x1", d => d.source.x)
            .attr("y1", d => d.source.y)
            .attr("x2", d => d.target.x)
            .attr("y2", d => d.target.y);

        node
            .attr("cx", d => d.x)
            .attr("cy", d => d.y);

        labels
            .attr("x", d => d.x)
            .attr("y", d => d.y);
    });
}
