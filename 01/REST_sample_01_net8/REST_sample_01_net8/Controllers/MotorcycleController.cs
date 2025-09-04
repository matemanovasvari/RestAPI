namespace REST_sample_01_net8.Controllers;

public class MotorcycleController : ControllerBase
{
    public List<string> Motorcycles = [
        "Honda Hornet",
        "Kawasaki Ninja H2",
        "Yamaha XV400 Virago"
    ];

    [HttpGet]
    [Route("motorcycle/id/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute][Required]int id){
        return Ok(Motorcycles[id]);
    }

    [HttpGet]
    [Route("motorcycle")]
    public async Task<IActionResult> GetByQueryAsync([FromQuery][Required] int id)
    {
        return Ok(Motorcycles[id]);
    }

    [HttpGet]
    [Route("motorcycle/all")]
    public async Task<IActionResult> GetByAllAsync(){
        return Ok(Motorcycles);
    }

    [HttpPost]
    [Route("motorcycle/create")]
    public async Task<IActionResult> CreateAsync([FromBody][Required]string motorcycle)
    {
        Motorcycles.Add(motorcycle);

        return Ok(Motorcycles);
    }

    [HttpPut]
    [Route("motorcycle/update")]
    public async Task<IActionResult> UpdateAsync([FromBody][Required] MotorcycleUpdateModel model)
    {
        Motorcycles[model.Id] = model.Name;

        return Ok(Motorcycles);
    }

    [HttpDelete]
    [Route("motorcycle/delete/{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute][Required] int id)
    {
        Motorcycles.RemoveAt(id);

        return Ok(Motorcycles);
    }
}