namespace REST_sample_02_net8.Controllers;

public class PhoneController : ControllerBase
{
    public List<string> Phones = [
        "IPhone 16 Pro Max",
        "Samsung Galaxy S25 Ultra",
        "Huawei Mate 20"
    ];

    [HttpGet]
    [Route("phone/id/{id}")]
    public async Task<IActionResult> GetByIdAsync([FromRoute][Required]int id){
        return Ok(Phones[id]);
    }

    [HttpGet]
    [Route("phone")]
    public async Task<IActionResult> GetByQueryAsync([FromQuery][Required] int id)
    {
        return Ok(Phones[id]);
    }

    [HttpGet]
    [Route("phone/all")]
    public async Task<IActionResult> GetByAllAsync(){
        return Ok(Phones);
    }

    [HttpPost]
    [Route("phone/create")]
    public async Task<IActionResult> CreateAsync([FromBody][Required]string phone)
    {
        Phones.Add(phone);

        return Ok(Phones);
    }

    [HttpPut]
    [Route("phone/update")]
    public async Task<IActionResult> UpdateAsync([FromBody][Required] PhoneUpdateModel model)
    {
        Phones[model.Id] = model.Name;

        return Ok(Phones);
    }

    [HttpDelete]
    [Route("phone/delete/{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute][Required] int id)
    {
        Phones.RemoveAt(id);

        return Ok(Phones);
    }
}