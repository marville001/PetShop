using PetShop.Domain.Enums;

namespace PetShop.Application.DTOs;

public class OrderDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public DateTime PickupDate { get; set; }
    public OrderStatus Status { get; set; }
    public decimal Cost { get; set; }
    public bool IsActualCost { get; set; }
    public List<PetDto> Pets { get; set; } = new();
}

public class CreateOrderDto
{
    public int CustomerId { get; set; }
    public DateTime PickupDate { get; set; }
}

public class UpdateOrderDto
{
    public DateTime? PickupDate { get; set; }
    public OrderStatus? Status { get; set; }
}

public class PetDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public PetKind Kind { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Breed { get; set; } = string.Empty;
    public int AgeInMonths { get; set; }
    public string Description { get; set; } = string.Empty;
}

public class CreatePetDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public PetKind Kind { get; set; }
    public string Color { get; set; } = string.Empty;
    public string Breed { get; set; } = string.Empty;
    public int AgeInMonths { get; set; }
    public string Description { get; set; } = string.Empty;
}