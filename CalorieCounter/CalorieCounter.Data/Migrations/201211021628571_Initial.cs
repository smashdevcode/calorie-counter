namespace CalorieCounter.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyTarget",
                c => new
                    {
                        DailyTargetID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Calories = c.Int(nullable: false),
                        DateUTC = c.DateTime(),
                    })
                .PrimaryKey(t => t.DailyTargetID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);

			CreateTable(
				"dbo.User",
				c => new
					{
						UserID = c.Int(nullable: false, identity: true),
						Username = c.String(nullable: false, maxLength: 20),
						HashedPassword = c.String(nullable: false),
						Name = c.String(nullable: false, maxLength: 50),
						Email = c.String(nullable: false, maxLength: 255),
					})
				.PrimaryKey(t => t.UserID)
				.Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.UserWeight",
                c => new
                    {
                        UserWeightID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 4, scale: 1),
                        DateUTC = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserWeightID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.FoodItem",
                c => new
                    {
                        FoodItemID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50),
                        ServingSize = c.String(nullable: false, maxLength: 100),
                        Calories = c.Int(),
                    })
                .PrimaryKey(t => t.FoodItemID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.FoodItemPart",
                c => new
                    {
                        FoodItemPartID = c.Int(nullable: false, identity: true),
                        FoodItemID = c.Int(nullable: false),
                        ContainsFoodItemID = c.Int(nullable: false),
                        Serving = c.Decimal(nullable: false, precision: 3, scale: 1),
                    })
                .PrimaryKey(t => t.FoodItemPartID)
                .ForeignKey("dbo.FoodItem", t => t.FoodItemID, cascadeDelete: true)
                .ForeignKey("dbo.FoodItem", t => t.ContainsFoodItemID)
                .Index(t => t.FoodItemID)
                .Index(t => t.ContainsFoodItemID);
            
            CreateTable(
                "dbo.LogEntry",
                c => new
                    {
                        LogEntryID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        MealTypeID = c.Int(nullable: false),
                        DateTimeUTC = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogEntryID)
                .ForeignKey("dbo.MealType", t => t.MealTypeID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.MealTypeID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.MealType",
                c => new
                    {
                        MealTypeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MealTypeID);
            
            CreateTable(
                "dbo.LogEntryFoodItem",
                c => new
                    {
                        LogEntryFoodItemID = c.Int(nullable: false, identity: true),
                        LogEntryID = c.Int(nullable: false),
                        FoodItemID = c.Int(nullable: false),
                        Serving = c.Decimal(nullable: false, precision: 3, scale: 1),
                    })
                .PrimaryKey(t => t.LogEntryFoodItemID)
                .ForeignKey("dbo.LogEntry", t => t.LogEntryID, cascadeDelete: true)
                .ForeignKey("dbo.FoodItem", t => t.FoodItemID, cascadeDelete: true)
                .Index(t => t.LogEntryID)
                .Index(t => t.FoodItemID);            
        }
        
        public override void Down()
        {
            DropIndex("dbo.LogEntryFoodItem", new[] { "FoodItemID" });
            DropIndex("dbo.LogEntryFoodItem", new[] { "LogEntryID" });
            DropIndex("dbo.LogEntry", new[] { "UserID" });
            DropIndex("dbo.LogEntry", new[] { "MealTypeID" });
            DropIndex("dbo.FoodItemPart", new[] { "ContainsFoodItemID" });
            DropIndex("dbo.FoodItemPart", new[] { "FoodItemID" });
            DropIndex("dbo.FoodItem", new[] { "UserID" });
            DropIndex("dbo.UserWeight", new[] { "UserID" });
			DropIndex("dbo.User", new[] { "Email" });
			DropIndex("dbo.DailyTarget", new[] { "UserID" });
            DropForeignKey("dbo.LogEntryFoodItem", "FoodItemID", "dbo.FoodItem");
            DropForeignKey("dbo.LogEntryFoodItem", "LogEntryID", "dbo.LogEntry");
            DropForeignKey("dbo.LogEntry", "UserID", "dbo.User");
            DropForeignKey("dbo.LogEntry", "MealTypeID", "dbo.MealType");
            DropForeignKey("dbo.FoodItemPart", "ContainsFoodItemID", "dbo.FoodItem");
            DropForeignKey("dbo.FoodItemPart", "FoodItemID", "dbo.FoodItem");
            DropForeignKey("dbo.FoodItem", "UserID", "dbo.User");
            DropForeignKey("dbo.UserWeight", "UserID", "dbo.User");
            DropForeignKey("dbo.DailyTarget", "UserID", "dbo.User");
            DropTable("dbo.LogEntryFoodItem");
            DropTable("dbo.MealType");
            DropTable("dbo.LogEntry");
            DropTable("dbo.FoodItemPart");
            DropTable("dbo.FoodItem");
            DropTable("dbo.UserWeight");
            DropTable("dbo.User");
            DropTable("dbo.DailyTarget");
        }
    }
}
