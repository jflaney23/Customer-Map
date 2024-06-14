using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CalculateModel : PageModel
{
    [BindProperty]
    public int RvLength { get; set; }
    [BindProperty]
    public int Distance { get; set; }
    [BindProperty]
    public string ?CustomerName { get; set; }
    public string ?Result { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        // Ensure model state is valid
        if (!ModelState.IsValid)
        {
            Result = "Invalid input";
            return;
        }

        // Perform the calculation
        var calculationResult = (RvLength * 10) + (Distance * 2);
        Result = $"Thank you for contacting us, {CustomerName}.\n" +
                 "Our Wash and Wax Foundational Package includes:\n\n" +
                 "- Cleaning roof and applying a protectant UV coating to plastics/seals to protect from cracking from the Sun\n" +
                 "- Cleaning and protecting awnings\n" +
                 "- Pressure-Washing exterior\n" +
                 "- Soaping and rinsing exterior\n" +
                 "- Manually applying a Polymer Sealant-Wax\n" +
                 "- Cleaning and protecting windows\n" +
                 "- Cleaning Wheels and applying a shine to tires\n\n" +
                 "**Please note that this package does NOT include Oxidation Removal**\n\n" +
                 $"For your vehicle, this comes to ${calculationResult}. We're mostly booked up for this month but still have a few available appointments.\n" +
                 "Is this something that you would be interested in?";
    }
}
