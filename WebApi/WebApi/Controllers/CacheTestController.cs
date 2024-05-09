using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using SqlSugar;
using WebApi.Entity;

namespace WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class CacheTestController:ControllerBase
{
    private readonly ISqlSugarClient _db;
    private readonly IDistributedCache _cache;
    public CacheTestController(ISqlSugarClient db,IDistributedCache cache)
    {
        this._cache = cache;
        this._db = db;
    }
    
    [HttpPost,Route("Get")]
    public async Task<object> Get()
    {
        var json = await _cache.GetStringAsync("WorkOrder");
        var list = JsonConvert.DeserializeObject<List<WorkOrderEntity>>(json);
        return json;
    }

    [HttpPost,Route("Set")]
    public async Task<object> Set()
    {
        var list = await _db.Queryable<WorkOrderEntity>().ToListAsync();
        
        await _cache.SetStringAsync("WorkOrder", JsonConvert.SerializeObject(list));
        
        return list;
    }

    [HttpGet,Route("Get")]
    public async Task<object> Get(string key)
    {
        var json = await _cache.GetStringAsync(key);
        
        //string res = System.Text.Encoding.UTF8.GetString(json);

        return json;

    }
    
    [HttpGet,Route("Set")]
    public async Task<object> Set(string key,string value)
    {
        await _cache.SetStringAsync(key, value);

        return true;

    }
}