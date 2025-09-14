import { Card, Group, Text, Progress, Badge, ThemeIcon } from "@mantine/core";
import { 
  UtensilsCrossed, 
  Car, 
  Gamepad2, 
  BookOpen, 
  ShoppingCart, 
  Coffee 
} from "lucide-react";

interface CategoryData {
  id: string;
  name: string;
  spent: number;
  budget: number;
  icon: React.ComponentType<{ className?: string }>;
  color: string;
}

const categories: CategoryData[] = [
  {
    id: "food",
    name: "Food",
    spent: 420,
    budget: 500,
    icon: UtensilsCrossed,
    color: "bg-blue-500"
  },
  {
    id: "transport",
    name: "Transport",
    spent: 180,
    budget: 200,
    icon: Car,
    color: "bg-green-500"
  },
  {
    id: "entertainment",
    name: "Entertainment",
    spent: 250,
    budget: 300,
    icon: Gamepad2,
    color: "bg-orange-500"
  },
  {
    id: "books",
    name: "Books",
    spent: 120,
    budget: 150,
    icon: BookOpen,
    color: "bg-red-500"
  },
  {
    id: "shopping",
    name: "Shopping",
    spent: 85,
    budget: 100,
    icon: ShoppingCart,
    color: "bg-purple-500"
  },
  {
    id: "coffee",
    name: "Coffee & Snacks",
    spent: 45,
    budget: 80,
    icon: Coffee,
    color: "bg-amber-500"
  }
];

function CategoryCard({ category }: { category: CategoryData }) {
  const { name, spent, budget, icon: Icon, color } = category;
  const percentage = (spent / budget) * 100;
  const isOverBudget = spent > budget;
  const remaining = budget - spent;

  return (
    <Card shadow="sm" padding="md" radius="md" withBorder>
      {/* Header row */}
      <Group justify="space-between" mb="sm" align="flex-start">
        <Group gap="sm">
          <ThemeIcon
            variant="light"
            radius="md"
            size="lg"
            color={color}
          >
            {/* Lucide icons don’t accept Mantine props, so use className */}
            <Icon className="w-4 h-4" />
          </ThemeIcon>
          <div>
            <Text fw={500}>{name}</Text>
            <Text size="sm" c="dimmed">
              ${spent} of ${budget}
            </Text>
          </div>
        </Group>
        <Badge
          variant="light"
          color={isOverBudget ? "red" : "gray"}
          radius="sm"
        >
          {percentage.toFixed(0)}%
        </Badge>
      </Group>

      {/* Progress bar */}
      <Progress
        value={Math.min(percentage, 100)}
        size="sm"
        radius="xl"
        color={isOverBudget ? "red" : "blue"}
        mb="xs"
      />

      {/* Footer row */}
      <Group justify="space-between">
        <Text size="sm" c="dimmed">
          {isOverBudget
            ? `Over by $${Math.abs(remaining).toFixed(2)}`
            : `$${remaining.toFixed(2)} remaining`}
        </Text>
        <Text size="sm" c={isOverBudget ? "red" : "dimmed"}>
          {percentage.toFixed(1)}%
        </Text>
      </Group>
    </Card>
  );
}

// function CategoryCard({ category }: { category: CategoryData }) {
//   const { name, spent, budget, icon: Icon, color } = category;
//   const percentage = (spent / budget) * 100;
//   const isOverBudget = spent > budget;
//   const remaining = budget - spent;

//   return (
//     <div style={{display: 'flex'}}>

//     </div>
//     // <Card className="hover:shadow-md transition-shadow">
//     //   <div className="p-6">
//     //     <div className="flex items-center justify-between mb-4">
//     //       <div className="flex items-center gap-3">
//     //         <div className={`p-2 rounded-lg ${color} bg-opacity-10`}>
//     //           <Icon className={`h-5 w-5 ${color.replace('bg-', 'text-')}`} />
//     //         </div>
//     //         <div>
//     //           <h3 className="font-medium">{name}</h3>
//     //           <p className="text-sm text-muted-foreground">
//     //             ${spent} of ${budget}
//     //           </p>
//     //         </div>
//     //       </div>
//     //       <Badge 
//     //         variant={isOverBudget ? "destructive" : "secondary"}
//     //         className="ml-2"
//     //       >
//     //         {percentage.toFixed(0)}%
//     //       </Badge>
//     //     </div>
        
//     //     <div className="space-y-2">
//     //       <Progress 
//     //         value={Math.min(percentage, 100)} 
//     //         className="h-2"
//     //         // Override the progress bar color based on status
//     //         style={{
//     //           '--progress-background': isOverBudget ? '#ef4444' : '#3b82f6'
//     //         } as React.CSSProperties}
//     //       />
//     //       <div className="flex justify-between text-sm">
//     //         <span className="text-muted-foreground">
//     //           {isOverBudget 
//     //             ? `Over by $${Math.abs(remaining).toFixed(2)}`
//     //             : `$${remaining.toFixed(2)} remaining`
//     //           }
//     //         </span>
//     //         <span className={isOverBudget ? "text-destructive" : "text-muted-foreground"}>
//     //           {percentage.toFixed(1)}%
//     //         </span>
//     //       </div>
//     //     </div>
//     //   </div>
//     // </Card>
//   );
// }

export function CategoryBudgets() {
  const totalSpent = categories.reduce((sum, cat) => sum + cat.spent, 0);
  const totalBudget = categories.reduce((sum, cat) => sum + cat.budget, 0);
  const overallPercentage = (totalSpent / totalBudget) * 100;

  return (
    <div className="space-y-6">
      {/* Overview Card */}
      <Card>
        <div>
          <div className="flex items-center justify-between">
            <Text>Budget Overview</Text>
            <Badge variant="outline" className="text-sm">
              ${totalSpent} / ${totalBudget}
            </Badge>
          </div>
        </div>
        <div>
          <div className="space-y-2">
            <Progress value={overallPercentage} className="h-3" />
            <div className="flex justify-between text-sm text-muted-foreground">
              <p>Overall spending: {overallPercentage.toFixed(1)}%</p>
              <p>${(totalBudget - totalSpent).toFixed(2)} remaining</p>
            </div>
          </div>
        </div>
      </Card>

      {/* Category Cards */}
      <div>
        <h2 className="font-medium mb-4">Categories</h2>
        <div style={{display:"flex", flexDirection:"column", gap:"10px"}}>
          {categories.map((category) => (
            <CategoryCard key={category.id} category={category} />
          ))}
        </div>
      </div>
    </div>
  );
}