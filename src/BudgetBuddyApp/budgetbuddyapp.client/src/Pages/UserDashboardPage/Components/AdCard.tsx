import { Card, Image, Text, Badge, Button, Group } from '@mantine/core';


export default function AdCard(){

    return(
        <>
            <Card shadow="sm" padding="lg" radius="md" withBorder>
            <Card.Section>
                <Image
                src="https://katana-coaching.ch/wp-content/uploads/2017/05/5f335619-f686-4e15-81c0-081934e4b326_16x9_788x442.jpg"
                height={100}
                alt="Norway"
                />
            </Card.Section>

            <Group justify="space-between" mt="md" mb="xs">
                <Text size='sm' fw={500}>Financial Service Provider</Text>
            </Group>

            <Text size="xs" c="dimmed">
                This card may occasionally display an advertisement from a financial services provider.
            </Text>

            <Button color="blue" fullWidth mt="md" radius="md">
                See More
            </Button>
            </Card>
        </>
    )
}