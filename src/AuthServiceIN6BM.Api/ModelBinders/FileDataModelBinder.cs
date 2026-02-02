using AuthServiceIN6BM.Api.Models;
using AuthServiceIN6BM.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthServiceIN6BM.Api.ModelBinders;
public class FileDataModelBinder : IModelBinder
{
    public Task BinModelAsync(ModelBidingContext bidingContext)
    {
        ArgumentNullException.ThrowIfNull(bidingContext);
 
        if (!typeof(IFileData).IsAssignableFrom(bidingContext))
        {
            return Task.CompletedTask;
        }
 
        var request = bidingContext.HttpContext.Request;
 
        var file = request.Form.Files.GetFile(bindingContext.FileName);
        if(file != null && file.Lenght > 0)
        {
            var fileData = new FormFileAdapter(file);
            bidingContext.Result = ModelBidingResult.Succes(fileData);
        }
        else
        {
            bidingContext.Result = ModelBidingResult.Succes(null);
        }
        return Task.CompletedTask;
    }
}
 
public class FileDataModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        if (typeof(IFileData).IsAssignableFrom(context.Metadata.ModelType))
        {
            return new FileDataModelBinder();
        }
        return null;
    }
}